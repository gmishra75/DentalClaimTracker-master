using System;
using System.IO;
using System.Text.RegularExpressions;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.Claims;
using NHDG.NHDGCommon.AppSettings;
using log4net;

namespace NHDG.ClaimCodeChanger {
	/// <summary>The main class of the program.</summary>
	public class ClaimCodeChanger {
		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		static int Main(string[] args) {
			string inputFile;
			string outputFile;
			ClaimBatch batch = null;

			// Set things up.
			Globals.Settings = (ClaimCodeChangerSettings)Utilities.DeserializeFromFile(typeof(ClaimCodeChangerSettings), SettingsManager.Instance.Settings["ClaimCodeChanger"].ConfigurationFile);
			log4net.Config.DOMConfigurator.ConfigureAndWatch(new System.IO.FileInfo(SettingsManager.Instance.Settings["ClaimCodeChanger"].LogConfigurationFile));
			Globals.Logger = LogManager.GetLogger("ClaimCodeChanger");

			// Say hello.
			Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			Globals.Logger.Info("Application starting: v" + v.ToString() +
								", Windows v" + System.Environment.OSVersion.Version.ToString() +
								", .NET v" + System.Environment.Version.ToString());


			// Figure out what file(s) to deal with.
			if (args.Length < 1) {
				Globals.Logger.Fatal("No input file was specified.");
				return -1;
			} else {
				inputFile = outputFile = args[0];
			}
			if (args.Length > 1) {
				outputFile = args[1];
			}
			if (!File.Exists(inputFile)) {
				Globals.Logger.Fatal("Specified input file does not exist (" + inputFile + ").");
				return -2;
			}

			// Read in the claims.
			try {
				Globals.Logger.Debug("Loading batch file...");
				batch = (ClaimBatch)Utilities.DeserializeFromFile(typeof(ClaimBatch), inputFile);
				Globals.Logger.Info("Batch file loaded (" + batch.Claims.Count.ToString() + " claims - " + inputFile + ").");
			} catch (Exception ex) {
				Globals.Logger.Fatal("Could not read batch file.", ex);
				return -4;
			}

			// Change procedure codes.
			int totalChanges = 0;
			foreach (Claim c in batch.Claims) {
				totalChanges += Change(c);
			}
            Globals.Logger.Info("Total of " + totalChanges.ToString() + " changes made.");

			// Write out the modified claims.
			try {
				Globals.Logger.Debug("Writing new batch file...");
				Utilities.SerializeToFile(batch, typeof(ClaimBatch), outputFile);
				Globals.Logger.Info("Wrote new batch file (" + batch.Claims.Count.ToString() + " claims - " + outputFile + ").");
			} catch (Exception ex) {
				Globals.Logger.Error("Could not write batch file.", ex);
				return -5;
			}

			// All done.
			Globals.Logger.Info("Application exiting.");
			return 0;
		}


		// Perform the search & replaces.
		static private int Change(Claim c) {
			int numChanges = 0;
			Regex r;
			string temp = string.Empty;

			foreach (CodeChange change in Globals.Settings.CodeChanges) {
				r = new Regex(change.Carrier, RegexOptions.IgnoreCase);
				if (!r.IsMatch(c.GeneralInformation.Carrier.Name)) { continue; }

				r = new Regex(change.SearchFor);
				foreach (Treatment t in c.TreatmentInformation.Treatments) {
					if (!r.IsMatch(t.ProcedureCode)) { continue; }

					temp = r.Replace(t.ProcedureCode, change.ReplaceWith);
					Globals.Logger.Debug("Replacing " + t.ProcedureCode + " with " + temp + " on claim " + c.Identity.ClaimID.ToString() + "/" + c.Identity.ClaimDB.ToString() + ".");
					t.ProcedureCode = temp;
					numChanges++;
				}
			}

			return numChanges;
		}
	}
}
