using System;
using System.Data.SqlClient;
using log4net;

namespace NHDG.EClaims {
	/// <summary>Contains the global classes/variables for the application.</summary>
	public class Globals {
		/// <summary>The database connection this program uses.</summary>
		static public SqlConnection Database;

		/// <summary>The logger to use for this application.</summary>
		static public ILog Logger;

		/// <summary>The application settings.</summary>
		static public EClaimsSettings Settings;
	}
}
