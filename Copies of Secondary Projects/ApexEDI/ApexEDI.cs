using System;
using System.IO;
using System.Data.SqlClient;
using NHDG.NHDGCommon;
using NHDG.NHDGCommon.Claims;
using NHDG.NHDGCommon.AppSettings;
using log4net;

namespace NHDG.ApexEDI {
	/// <summary>The main class of the program.</summary>
	public class ApexEDI {
		/// <summary>The main entry point for the application.</summary>
		[STAThread]
		static int Main(string[] args) {
			string inputFile;
			string outputFile;
			ClaimBatch batch = null;

			// Set things up.
			log4net.Config.DOMConfigurator.ConfigureAndWatch(new System.IO.FileInfo(SettingsManager.Instance.Settings["ApexEDI"].LogConfigurationFile));
			Globals.Logger = LogManager.GetLogger("ApexEDI");

			// Read in the file layout information.
			try {
				Globals.Logger.Debug("Loading file format information (" + SettingsManager.Instance.Settings["ApexEDI"].ConfigurationFile + ")...");
				Globals.Format = (FileFormat)Utilities.DeserializeFromFile(typeof(FileFormat), SettingsManager.Instance.Settings["ApexEDI"].ConfigurationFile);
				Globals.Logger.Debug("File format information loaded.");
			} catch (Exception ex) {
				Globals.Logger.Fatal("Could not load file format information.", ex);
				return -3;
			}

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
				inputFile = args[0];
			}
			if (args.Length > 1) {
				outputFile = args[1];
			} else {
				outputFile = Path.ChangeExtension(inputFile, ".apexedi");
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

			// Write the claims in the ApexEDI format.
			int i = 0;
			StreamWriter sw = null;
			try {
				sw = new StreamWriter(outputFile, true, System.Text.Encoding.ASCII);
			} catch (Exception ex) {
				Globals.Logger.Fatal("Could not open " + outputFile + " for output.", ex);
				return -5;
			}
			bool first = true;
			foreach (Claim c in batch.Claims) {
				try {
					// Separate the claims.
					if (first) {
						first = false;
					} else {
						if (Globals.Format.General.ClaimSeparator != string.Empty) {
							sw.WriteLine(Globals.Format.General.ClaimSeparator);
						}
					}

					WriteClaim(sw, c);
					i++;
				} catch (Exception ex) {
					Globals.Logger.Error("There was an error transforming claim " + c.Identity.ClaimID.ToString() + "/" + c.Identity.ClaimDB.ToString() + ".", ex);
					first = true;
				}
			}
			sw.Close();
			Globals.Logger.Info(i.ToString() + " of " + batch.Claims.Count.ToString() + " claims written to " + outputFile);

			// All done.
			Globals.Logger.Info("Application exiting.");
			return 0;
		}


		// Builds the workspace which consists of blank lines.
		static private string[] BuildWorkspace() {
			string[] temp = new string[Globals.Format.MaxLength];
			for (int i = 0; i < temp.Length; i++) {
				temp[i] = Utilities.Repeat(Globals.Format.General.EmptyCharacter.ToString(), Globals.Format.MaxWidth);
			}
			return temp;
		}


		// Populates a field on the workspace with the data given.
		static private void PlaceFieldString(string[] workspace, Field f, string data) {
			if (f == null) { return; }
			PlaceFieldString(workspace, f, data, f.Line);
		}

		// Populates a field on the workspace with the data given.
		static private void PlaceFieldString(string[] workspace, Field f, string data, int lineOverride) {
			if (f == null) { return; }
			string temp;
			int width = (f.EndColumn - f.StartColumn) + 1;
			temp = workspace[lineOverride - 1].Substring(0, (f.StartColumn - 1));
			temp += Utilities.Truncate(data, width).PadRight(width, Globals.Format.General.EmptyCharacter);
			temp += workspace[lineOverride - 1].Substring(f.EndColumn, (workspace[lineOverride - 1].Length - f.EndColumn));
			workspace[lineOverride - 1] = temp;
		}

		// Populates a checkbox field on the workspace.
		static private void CheckField(string[] workspace, Field f) {
			PlaceFieldString(workspace, f, Globals.Format.General.CheckboxCharacter.ToString());
		}


		// Write out the claim in the crazy ApexEDI format. *sigh*
		static private void WriteClaim(StreamWriter sw, Claim c) {
			string[] workspace = BuildWorkspace();

			// Write the fields.
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Accident.Description"), c.BillingDentist.Accident.Description);
			CheckField(workspace, Globals.Format.GetField("BillingDentist.Accident.Type." + c.BillingDentist.Accident.Type.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Address.City"), c.BillingDentist.Address.City);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Address.State"), c.BillingDentist.Address.State);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Address.Street1"), c.BillingDentist.Address.Street1 + " " + c.BillingDentist.Address.Street2);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Address.Zip"), c.BillingDentist.Address.Zip);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.FirstDateOfSeries"), c.BillingDentist.FirstDateOfSeries);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.ID"), c.BillingDentist.ID);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.License"), c.BillingDentist.License);
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Name"), c.BillingDentist.Name);
			if (c.BillingDentist.NumRadiographsEnclosed > 0) {
				PlaceFieldString(workspace, Globals.Format.GetField(""), c.BillingDentist.NumRadiographsEnclosed.ToString());
				CheckField(workspace, Globals.Format.GetField("BillingDentist.RadiographsEnclosed.True"));
			} else {
				CheckField(workspace, Globals.Format.GetField("BillingDentist.RadiographsEnclosed.False"));
			}
			if (c.BillingDentist.Occupational.TreatmentResultOfOccupation) {
				PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Occupational.Description"), c.BillingDentist.Occupational.Description);
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Occupational.TreatmentResultOfOccupation.True"));
			} else {
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Occupational.TreatmentResultOfOccupation.False"));
			}
			if (c.BillingDentist.Orthodontics.TreatmentForOrthodontics) {
				PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Orthodontics.DateAppliancePlaced"), c.BillingDentist.Orthodontics.DateAppliancePlaced);
				PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Orthodontics.RemainingMonths"), c.BillingDentist.Orthodontics.RemainingMonths.ToString());
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Orthodontics.TreatmentForOrthodontics.True"));
			} else {
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Orthodontics.TreatmentForOrthodontics.False"));
			}
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.PhoneNumber"), c.BillingDentist.PhoneNumber);
			CheckField(workspace, Globals.Format.GetField("BillingDentist.PlaceOfTreatment." + c.BillingDentist.PlaceOfTreatment.ToString()));
			if (c.BillingDentist.Prosthesis.InitialReplacement == "Yes") {
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Prosthesis.InitialReplacement.True"));
			} else if (c.BillingDentist.Prosthesis.InitialReplacement == "No") {
				CheckField(workspace, Globals.Format.GetField("BillingDentist.Prosthesis.InitialReplacement.False"));
				PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Prosthesis.PriorPlacement"), c.BillingDentist.Prosthesis.PriorPlacement);
				PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.Prosthesis.ReasonForReplacement"), c.BillingDentist.Prosthesis.ReasonForReplacement);
			}
			PlaceFieldString(workspace, Globals.Format.GetField("BillingDentist.TIN"), c.BillingDentist.TIN);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.Carrier.Address.City"), c.GeneralInformation.Carrier.Address.City + ", " + c.GeneralInformation.Carrier.Address.State + " " + c.GeneralInformation.Carrier.Address.Zip);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.Carrier.Address.Street1"), c.GeneralInformation.Carrier.Address.Street1 + " " + c.GeneralInformation.Carrier.Address.Street2);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.Carrier.Name"), c.GeneralInformation.Carrier.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.Date"), c.GeneralInformation.Date);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.PriorAuthorization"), c.GeneralInformation.PriorAuthorization);
			CheckField(workspace, Globals.Format.GetField("GeneralInformation.Purpose." + c.GeneralInformation.Purpose.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.Specialty"), c.GeneralInformation.Specialty);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.TreatmentLocation.City"), c.GeneralInformation.TreatmentLocation.City);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.TreatmentLocation.State"), c.GeneralInformation.TreatmentLocation.State);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.TreatmentLocation.Street1"), c.GeneralInformation.TreatmentLocation.Street1 + " " + c.GeneralInformation.TreatmentLocation.Street2);
			PlaceFieldString(workspace, Globals.Format.GetField("GeneralInformation.TreatmentLocation.Zip"), c.GeneralInformation.TreatmentLocation.Zip);
			CheckField(workspace, Globals.Format.GetField("GeneralInformation.Type." + c.GeneralInformation.Type.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("Identity.ClaimDB"), c.Identity.ClaimDB.ToString());
			PlaceFieldString(workspace, Globals.Format.GetField("Identity.ClaimID"), c.Identity.ClaimID.ToString());
			PlaceFieldString(workspace, Globals.Format.GetField("Identity.OtherClaimDB"), c.Identity.OtherClaimDB.ToString());
			PlaceFieldString(workspace, Globals.Format.GetField("Identity.OtherClaimID"), c.Identity.OtherClaimID.ToString());
			CheckField(workspace, Globals.Format.GetField("Identity.Type." + c.Identity.Type.ToString()));
			if (c.OtherPolicy == null) {
				CheckField(workspace, Globals.Format.GetField("OtherPolicy.Exists.False"));
			} else {
				CheckField(workspace, Globals.Format.GetField("OtherPolicy.Exists.True"));
				CheckField(workspace, Globals.Format.GetField("OtherPolicy.Type." + c.OtherPolicy.Type.ToString()));
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.PlanName"), c.OtherPolicy.PlanName);
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.PolicyNumber"), c.OtherPolicy.PolicyNumber);
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.SubscriberBirthDate"), c.OtherPolicy.SubscriberBirthDate);
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.SubscriberEmployer.Address"), c.OtherPolicy.SubscriberEmployer.Address);
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.SubscriberEmployer.Name"), c.OtherPolicy.SubscriberEmployer.Name);
				PlaceFieldString(workspace, Globals.Format.GetField("OtherPolicy.SubscriberName"), c.OtherPolicy.SubscriberName);
				CheckField(workspace, Globals.Format.GetField("OtherPolicy.SubscriberSex." + c.OtherPolicy.SubscriberSex.ToString()));
			}
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Address.City"), c.Patient.Address.City);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Address.State"), c.Patient.Address.State);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Address.Street1"), c.Patient.Address.Street1 + " " + c.Patient.Address.Street2);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Address.Zip"), c.Patient.Address.Zip);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.BirthDate"), c.Patient.BirthDate);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Employer.Address"), c.Patient.Employer.Address);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Employer.Name"), c.Patient.Employer.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.ID"), c.Patient.ID);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.Name"), c.Patient.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("Patient.PhoneNumber"), c.Patient.PhoneNumber);
			CheckField(workspace, Globals.Format.GetField("Patient.Sex." + c.Patient.Sex.ToString()));
			CheckField(workspace, Globals.Format.GetField("Patient.SubscriberRelationship." + c.Patient.SubscriberRelationship.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Address.City"), c.Subscriber.Address.City);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Address.State"), c.Subscriber.Address.State);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Address.Street1"), c.Subscriber.Address.Street1 + " " + c.Subscriber.Address.Street2);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Address.Zip"), c.Subscriber.Address.Zip);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.BirthDate"), c.Subscriber.BirthDate);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Employer.Name"), c.Subscriber.Employer.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Employer.Name40"), c.Subscriber.Employer.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Employer.Address"), c.Subscriber.Employer.Address);
			CheckField(workspace, Globals.Format.GetField("Subscriber.EmploymentStatus." + c.Subscriber.EmploymentStatus.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.GroupNumber"), c.Subscriber.GroupNumber);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.ID"), c.Subscriber.ID);
			CheckField(workspace, Globals.Format.GetField("Subscriber.MaritalStatus." + c.Subscriber.MaritalStatus.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.Name"), c.Subscriber.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("Subscriber.PhoneNumber"), c.Subscriber.PhoneNumber);
			CheckField(workspace, Globals.Format.GetField("Subscriber.Sex." + c.Subscriber.Sex.ToString()));
			PlaceFieldString(workspace, Globals.Format.GetField("TreatmentInformation.PaymentByOtherPlan"), c.TreatmentInformation.PaymentByOtherPlan);
			PlaceFieldString(workspace, Globals.Format.GetField("TreatmentInformation.RemarksForUnusualServices"), c.TreatmentInformation.RemarksForUnusualServices);
			PlaceFieldString(workspace, Globals.Format.GetField("TreatmentInformation.TotalFee"), c.TreatmentInformation.TotalFee.Replace(",", string.Empty));

			// Signatures.
			PlaceFieldString(workspace, Globals.Format.GetField("PatientSignature.AgreeToFees"), "SIGNATURE ON FILE");
			PlaceFieldString(workspace, Globals.Format.GetField("PatientSignature.AgreeToFees.Date"), c.GeneralInformation.Date);
			PlaceFieldString(workspace, Globals.Format.GetField("PatientSignature.AuthorizeDirectPayment"), "SIGNATURE ON FILE");
			PlaceFieldString(workspace, Globals.Format.GetField("PatientSignature.AuthorizeDirectPayment.Date"), c.GeneralInformation.Date);
			PlaceFieldString(workspace, Globals.Format.GetField("ProviderSignature"), c.BillingDentist.Name);
			PlaceFieldString(workspace, Globals.Format.GetField("ProviderSignature.License"), c.BillingDentist.License);
			PlaceFieldString(workspace, Globals.Format.GetField("ProviderSignature.Date"), c.GeneralInformation.Date);

			// Write the treatments.
			int i = Globals.Format.General.TreatmentLinesStart;
			foreach (Treatment t in c.TreatmentInformation.Treatments) {
				if (i == (Globals.Format.General.TreatmentLinesStart + Globals.Format.General.MaxNumberTreatments)) {
					Globals.Logger.Warn("Claim " + c.Identity.ClaimID.ToString() + "/" + c.Identity.ClaimDB.ToString() + " had more treatments than file format allows (" + c.TreatmentInformation.Treatments.Count + ").");
					break;
				}
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.Description"), t.Description, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.DiagnosisIndex"), t.DiagnosisIndex, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.Fee"), t.Fee.Replace(",", string.Empty), i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.ProcedureCode"), t.ProcedureCode, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.ProcedureDate"), t.ProcedureDate, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.Quantity"), t.Quantity, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.Surface"), t.Surface, i);
				PlaceFieldString(workspace, Globals.Format.GetField("Treatment.Tooth"), t.Tooth, i);
				i++;
			}

			// Write out the workspace.
			foreach (string s in workspace) {
				sw.WriteLine(s);
			}
			sw.Flush();
		}
	}
}
