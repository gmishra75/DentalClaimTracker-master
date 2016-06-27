using System;
using log4net;

namespace NHDG.ClaimCodeChanger {
	/// <summary>Contains the global classes/variables for the application.</summary>
	public class Globals {
		/// <summary>The logger to use for this application.</summary>
		static public ILog Logger;

		/// <summary>The application settings.</summary>
		static public ClaimCodeChangerSettings Settings;
	}
}
