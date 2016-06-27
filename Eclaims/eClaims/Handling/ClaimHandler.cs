using System;
using System.Collections;
using System.Data.SqlClient;
using System.Xml.Serialization;
using NHDG.NHDGCommon.Claims;

namespace NHDG.EClaims.Handling {
	/// <summary>Represents a method for handling a claim.</summary>
	public class ClaimHandler {
		/// <summary>The name of the handler.</summary>
		public string Name = string.Empty;

		/// <summary>The batch that this handler is currently using.</summary>
		[XmlIgnore]
		public ClaimBatch Batch = null;


		/// <summary>Create a batch in the database.</summary>
		/// <param name="trans">The transaction to create the batch in.</param>
		/// <remarks>During the save the BatchID is retrieved and saved in the field.</remarks>
		virtual public void CreateBatch(SqlTransaction trans) {
			Batch = new ClaimBatch();
			Batch.BatchInformation.DateCreated = DateTime.Now;

			// Create the batch entry.
			SqlCommand cmd = new SqlCommand("INSERT INTO NHDG_CLAIM_BATCHES " +
											"(BATCH_DATE, HANDLING) " +
											"VALUES " +
											"('" + Batch.BatchInformation.DateCreated.ToString("d") + "', " +
											"'" + Name + "'); " +
											"SELECT SCOPE_IDENTITY() AS ID;", trans.Connection, trans);

			// Get the database batch ID.
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			Batch.BatchInformation.BatchID = (int)reader.GetDecimal(0);
			reader.Close();
		}


		/// <summary>Add a claim to the batch.</summary>
		/// <param name="trans">The transaction to add the claim in.</param>
		/// <param name="c">The claim to add.</param>
		/// <returns>Whether or not the add was successful.</returns>
		virtual public bool AddClaim(SqlTransaction trans, Claim c) {
			if (Batch == null) { throw new Exception("A batch must be created before a claim can be added."); }

			// Wipe out the resubmit flag.
			SqlCommand cmd = new SqlCommand("UPDATE NHDG_CLAIM_TRANSACTIONS " +
											"SET RESUBMIT_FLAG = NULL, " +
											"    BATCH_RESUBMITTED = " + Batch.BatchInformation.BatchID.ToString() + " " +
											"WHERE (CLAIM_ID = " + c.Identity.ClaimID.ToString() + ") " +
											"  AND (CLAIM_DB = " + c.Identity.ClaimDB.ToString() + ") " +
											"  AND (RESUBMIT_FLAG = 'Y')", trans.Connection, trans);
			cmd.ExecuteNonQuery();

			// Add the claim to the batch.
			cmd = new SqlCommand("INSERT INTO NHDG_CLAIM_TRANSACTIONS " +
								"(CLAIM_ID, CLAIM_DB, CLAIMBATCHID) " +
								"VALUES " +
								"(" + c.Identity.ClaimID.ToString() + ", " +
								c.Identity.ClaimDB.ToString() + ", " +
								Batch.BatchInformation.BatchID.ToString() + ")", trans.Connection, trans);
			return (cmd.ExecuteNonQuery() == 1);
		}
	}
}
