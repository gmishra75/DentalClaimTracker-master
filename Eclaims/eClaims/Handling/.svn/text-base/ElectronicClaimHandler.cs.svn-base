using System;
using System.Collections;
using System.Data.SqlClient;
using System.Xml.Serialization;
using NHDG.NHDGCommon.Claims;

namespace NHDG.EClaims.Handling {
	/// <summary>Handles claims designated as electronic.</summary>
	public class ElectronicClaimHandler : ClaimHandler {
		/// <summary>The offices or sources of deposit batches.</summary>
		[XmlArrayItem(typeof(Command))]
		public ArrayList PostProcessing = new ArrayList();

		/// <summary>Whether or not to delete the XML dump of the claim batch after processing.</summary>
		public bool DeleteXMLBatch = false;


		/// <summary>Add a claim to the batch.</summary>
		/// <param name="trans">The transaction to add the claim in.</param>
		/// <param name="c">The claim to add.</param>
		/// <returns>Whether or not the add was successful.</returns>
		override public bool AddClaim(SqlTransaction trans, Claim c) {
			if (base.AddClaim(trans, c)) {
				Batch.Claims.Add(c);
				return true;
			}

			return false;
		}


		/// <summary>Perform the processing on the claim batch.</summary>
		public void Process() {
			// Create a file with the claims.
			string tempFile = "nhdg.claims." + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xml";
			tempFile = System.IO.Path.Combine(Globals.Settings.TemporaryDirectory, tempFile);
			NHDG.NHDGCommon.Utilities.SerializeToFile(Batch, typeof(ClaimBatch), tempFile);

			// Execute the processing.
			System.Diagnostics.ProcessStartInfo psi;
			System.Diagnostics.Process proc;
			foreach (Command c in PostProcessing) {
				if (c.Executable.Trim() == string.Empty) { continue; }

				psi = new System.Diagnostics.ProcessStartInfo();
				psi.FileName = c.Executable;
				psi.Arguments = string.Format(c.Arguments, tempFile);
				proc = System.Diagnostics.Process.Start(psi);
				proc.WaitForExit();
				proc.Close();
			}

			// Clean up after ourself.
			if (DeleteXMLBatch) {
				System.IO.File.Delete(tempFile);
			}
		}
	}


	/// <summary>Represents a command that will be executed during the processing of electronic claims.</summary>
	public class Command {
		/// <summary>The path to the executable.</summary>
		public string Executable = string.Empty;

		/// <summary>The command-line arguments to pass to the executable.</summary>
		/// <remarks>The identifier {0} will be replaced with the path to the file containing the XML claim batch.</remarks>
		public string Arguments = string.Empty;
	}
}
