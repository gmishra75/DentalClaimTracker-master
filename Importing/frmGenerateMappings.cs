using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmGenerateMappings : Form
    {
        private List<MappingGeneratorDataItem> _generatedFields;
        private List<data_mapping_field> _existingFields;
        private data_mapping_field _workingObject;

        public frmGenerateMappings()
        {
            InitializeComponent();
            _existingFields = new List<data_mapping_field>();
            _workingObject = new data_mapping_field();
            _generatedFields = new List<MappingGeneratorDataItem>();
            MappingGeneratorDataItem _workingItem;

            // Get existing data mappings
            DataTable allFields = _workingObject.Search(_workingObject.SearchSQL + " ORDER BY table_name, field_name");            
            foreach (DataRow aRow in allFields.Rows)
            {
                _workingObject = new data_mapping_field();
                _workingObject.Load(aRow);
                _existingFields.Add(_workingObject);
            }


            for (int i = 0; i < 4; i++)
            {
                string tableName;
                switch (i)
                {
                    case 0:
                        tableName = "claims";
                        break;
                    case 1:
                        tableName = "companies";
                        break;
                    case 2:
                        tableName = "company_contact_info";
                        break;
                    case 3:
                        tableName = "procedures";
                        break;
                    default:
                        throw new Exception("Unitialized table in generate mappings.");
                }

                // Retrieve column information
                // Use Connection object for the DataAdapter to retrieve all tables from selected Database
                DataTable columnsTable = _workingObject.Search("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "' ORDER BY Column_Name");
                foreach (DataRow aColumn in columnsTable.Rows)
                {
                    _workingItem = new MappingGeneratorDataItem();
                    _workingItem.Table_Name = tableName;
                    _workingItem.Field_Name = aColumn["Column_Name"].ToString();
                    _workingItem.Field_Type = aColumn["Data_Type"].ToString();
                    _workingItem.ExistingMapping = _existingFields.Find(delegate(data_mapping_field dmf)
                        { return ((dmf.table_name == _workingItem.Table_Name) && (dmf.field_name == _workingItem.Field_Name)); });
                    _workingItem.Exists = _workingItem.ExistingMapping != null;
                    _workingItem.Map_Field = _workingItem.Exists;
                    _generatedFields.Add(_workingItem);
                }
            }

            
        }

        private static bool HasAMatch(data_mapping_field mapping_field, string field_name, string table_name)
        {
            if ((mapping_field.field_name == field_name) &&
                (mapping_field.table_name == table_name))
                return true;
            else
                return false;
        }


        private void frmGenerateMappings_Load(object sender, EventArgs e)
        {
            dgvColumns.DataSource = _generatedFields;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow aRow in dgvColumns.Rows)
            {
                MappingGeneratorDataItem mgdi = (MappingGeneratorDataItem) aRow.Cells["colMappingGeneratorItem"].Value;
                data_mapping_field _workingObject = new data_mapping_field();
                if ((!mgdi.Exists) && (mgdi.Map_Field))
                {
                    // Create a mapping field
                    _workingObject = new data_mapping_field();
                    _workingObject.table_name = mgdi.Table_Name;
                    _workingObject.field_name = mgdi.Field_Name;
                    _workingObject.field_type = mgdi.Field_Type;
                    _workingObject.Save();
                }
                else if (mgdi.Exists && !mgdi.Map_Field)
                {
                    // Remove a mapping field
                    _workingObject = mgdi.ExistingMapping;
                    _workingObject.Delete();
                }
            }

            MessageBox.Show(this, "The requested changes have been processed.", "Operation Complete");
            Close();
        }
    }

    public class MappingGeneratorDataItem
    {
        private string _table_name;
        private string _field_name;
        private string _field_type;
        private bool _exists;
        private bool _mapped;
        private data_mapping_field _existingMapping;

        public string Table_Name
        {
            get { return _table_name; }
            set { _table_name = value; }
        }
        public string Field_Name
        {
            get { return _field_name; }
            set { _field_name = value; }
        }
        public string Field_Type
        {
            get { return _field_type; }
            set { _field_type = value; }
        }
        public bool Exists
        {
            get { return _exists; }
            set { _exists = value; }
        }
        public bool Map_Field
        {
            get { return _mapped; }
            set { _mapped = value; }
        }
        public data_mapping_field ExistingMapping
        {
            get { return _existingMapping; }
            set { _existingMapping = value; }
        }

        public MappingGeneratorDataItem thisObject
        {
            get { return this; }
        }


    }
}