using System;
using System.Data.SqlClient;
using log4net;

namespace NHDG.ApexEDI {
	/// <summary>Contains the global classes/variables for the application.</summary>
	public class Globals {
		/// <summary>The logger to use for this application.</summary>
		static public ILog Logger;

		/// <summary>The database connection this program uses.</summary>
		static public SqlConnection Database;

		/// <summary>The file layout information.</summary>
		static public FileFormat Format;
	}
}
