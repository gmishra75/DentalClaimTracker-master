using System;
using System.Collections;
using System.Xml.Serialization;

namespace NHDG.ApexEDI {
	/// <summary>Contains the layout of the ApexEDI claim file.</summary>
	[XmlRoot("ApexEDI")]
	public class FileFormat {
		/// <summary>General information about the file.</summary>
		public GeneralFileInformation General = new GeneralFileInformation();

		/// <summary>The locations of the individual fields.</summary>
		[XmlArrayItem(ElementName="Field", Type=typeof(Field))]
		public ArrayList Fields = new ArrayList();


		/// <summary>Returns the last column that could be populated.</summary>
		public int MaxWidth {
			get {
				int max = 0;
				foreach (Field f in Fields) {
					if (f.EndColumn > max) {
						max = f.EndColumn;
					}
				}
				return max;
			}
		}

		/// <summary>Returns the last line that could be populated.</summary>
		public int MaxLength {
			get {
				int max = 0;
				foreach (Field f in Fields) {
					if (f.Line > max) {
						max = f.Line;
					}
				}
				return max;
			}
		}


		/// <summary>Retrieve field location information for a given field.</summary>
		/// <param name="name">The field to get the information for.</param>
		/// <returns>The location information.</returns>
		/// <remarks>If the field is not found, null is returned.</remarks>
		public Field GetField(string name) {
			foreach (Field f in Fields) {
				if (f.Name == name) {
					return f;
				}
			}

			return null;
		}
	}


	/// <summary>General information about a file.</summary>
	public class GeneralFileInformation {
		/// <summary>The string to separate claims with in a file.</summary>
		/// <remarks>An empty string will result in the claims being placed one right after another.</remarks>
		public string ClaimSeparator = string.Empty;

		/// <summary>The character to use when marking checkboxes.</summary>
		public char CheckboxCharacter = 'X';

		/// <summary>The character to use to represent a non-populated character in the file.</summary>
		public char EmptyCharacter = ' ';

		/// <summary>The line where the treatment listing should begin.</summary>
		public int TreatmentLinesStart = 32;

		/// <summary>The maximum number of treatments to write.</summary>
		public int MaxNumberTreatments = 20;
	}


	/// <summary>Contains information regarding the location of a single field.</summary>
	public class Field {
		/// <summary>The name of the field.</summary>
		public string Name = string.Empty;

		/// <summary>The line to put the data.</summary>
		public int Line = 0;

		/// <summary>The column to start writing the data.</summary>
		public int StartColumn = 0;

		/// <summary>The last column this field can occupy.</summary>
		public int EndColumn = 0;
	}
}
