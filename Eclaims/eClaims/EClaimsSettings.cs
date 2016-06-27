using System;
using System.Collections;
using System.Xml.Serialization;
using NHDG.EClaims.Handling;

namespace NHDG.EClaims {
	/// <summary>A class that groups the settings for the EClaims application.</summary>
	[XmlRoot("EClaims")]
	public class EClaimsSettings {
		/// <summary>The batches to hide in the batch history screen.</summary>
		public string ExcludeBatchIDs = string.Empty;

		/// <summary>The temporary directory to use when creating claim batches.</summary>
		public string TemporaryDirectory = string.Empty;

		/// <summary>The handling methods available for use.</summary>
		[XmlArrayItem(typeof(ManualClaimHandler)), XmlArrayItem(typeof(ElectronicClaimHandler))]
		public ArrayList Handlers = new ArrayList();


		/// <summary>Retreive the handler with the given name.</summary>
		/// <param name="name">The name of the handler to retrieve.</param>
		/// <returns>The handler with the given name.</returns>
		public ClaimHandler GetHandlerByName(string name) {
			foreach (ClaimHandler ch in Handlers) {
				if (ch.Name == name) {
					return ch;
				}
			}

			return null;
		}


		/// <summary>Resets all of the handlers to prepare for a new batch.</summary>
		public void ResetHandlers() {
			foreach (ClaimHandler ch in Handlers) {
				ch.Batch = null;
			}
		}
	}
}
