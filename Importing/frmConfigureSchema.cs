using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmConfigureSchema : Form
    {
        data_mapping_schema _formSchema;
        private bool _dataChanged = false;

        public frmConfigureSchema(data_mapping_schema schemaToLoad)
        {
            InitializeComponent();
            _formSchema = schemaToLoad;
            InitializeDataTypesDropDown();
            LoadData();
        }

        public string SchemaName
        {
            get { return txtSchemaName.Text; }
        }

        private void InitializeDataTypesDropDown()
        {
            cmbDataType.Items.Add(DataMappingConnectionTypes.SQLServer);
            cmbDataType.Items.Add(DataMappingConnectionTypes.MySQL);
            cmbDataType.Items.Add(DataMappingConnectionTypes.Access);
            cmbDataType.Items.Add(DataMappingConnectionTypes.CSV);
        }


        /// <summary>
        /// Loads the data for the current schema, or the first schema. If no schema is found,
        /// creates a default schema
        /// </summary>
        private void LoadData()
        {
            #region Fields
            txtSchemaName.Text = _formSchema.schema_name;
            cmbDataType.SelectedIndex = (int)_formSchema.data_type;
            txtSQL.Text = _formSchema.sqlstatement;
            txtServerName.Text = _formSchema.server_name;
            txtDatabaseName.Text = _formSchema.database_name;
            txtUserName.Text = _formSchema.user_name;
            chkAllowSavePassword.Checked = System.Convert.ToBoolean(_formSchema.allow_password_save);
            txtPassword.Text = _formSchema.pw;
            txtClaimIDColumn.Text = _formSchema.claim_id_column;
            txtCompanyNameColumn.Text = _formSchema.company_namecolumn;
            txtDateColumn.Text = _formSchema.date_column;
            txtSQLSecondary.Text = _formSchema.sqlstatementsecondaries;
            txtSQLPredeterm.Text = _formSchema.sqlstatementpredeterms;
            txtSQLSecondaryPredeterm.Text = _formSchema.sqlstatementsecondarypredeterms;
            txtClaimDBColumn.Text = _formSchema.claim_db_column;
            
            #endregion
            List<FieldMappingDisplay> allMappedFields = new List<FieldMappingDisplay>();
            FieldMappingDisplay fmd;
            data_mapping_field mappingFields = new data_mapping_field();
            DataTable allFields = mappingFields.Search(mappingFields.SearchSQL + " ORDER BY table_name, field_name");

            foreach (DataRow aField in allFields.Rows)
            {
                fmd = new FieldMappingDisplay();
                mappingFields = new data_mapping_field();
                mappingFields.Load(aField);
                fmd.FieldName = mappingFields.field_name;
                fmd.TableName = mappingFields.table_name;
                fmd.FieldData = mappingFields;
                
                fmd.LinkedField = GetLinkedField(mappingFields);

                allMappedFields.Add(fmd);
            }

            dgvMappings.DataSource = allMappedFields;
            _dataChanged = false;
        }

        private string GetLinkedField(data_mapping_field mappingFields)
        {
            foreach (data_mapping_schema_data aMapping in _formSchema.LinkedSchemaData)
            {
                if (aMapping.mapping_field_id == mappingFields.id)
                {
                    return aMapping.mapped_to_text;
                }
            }

            return "";
        }

        private void lnkRegenerateMappings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool okToOpen = true;
            if (_dataChanged)
            {
                if (MessageBox.Show(this, "The current data has changed. You must save the data if you wish to " +
                    "regenerate the data mappings. Would you like to save now?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save();
                    okToOpen = true;
                }
                else
                    okToOpen = false;
            }

            if (okToOpen)
            {

                frmGenerateMappings toShow = new frmGenerateMappings();
                toShow.ShowDialog();

                LoadData();
            }
        }

        private bool RecordChangeOK()
        {
            if (_dataChanged)
            {
                // Check with user if current record should be saved
                DialogResult _changeOK = MessageBox.Show("The current data has been changed. Would you like to save it before continuing?",
                    "Data Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (_changeOK == DialogResult.Yes)
                {
                    Save();
                    return true;
                }
                else if (_changeOK == DialogResult.No)
                {
                    // Do not save changes
                    _dataChanged = false;
                    return true;
                }
                else
                {
                    // Cancel move
                    return false;
                }
            }
            else
                return true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            // We have to remove all the existing data and insert the new data to save properly

            #region Fields
            _formSchema.schema_name = txtSchemaName.Text;
            _formSchema.data_type = (DataMappingConnectionTypes) cmbDataType.SelectedItem;
            _formSchema.sqlstatement = txtSQL.Text;
            _formSchema.server_name = txtServerName.Text;
            _formSchema.database_name = txtDatabaseName.Text;
            _formSchema.user_name = txtUserName.Text;
            _formSchema.allow_password_save = chkAllowSavePassword.Checked;
            _formSchema.claim_id_column = txtClaimIDColumn.Text;
            _formSchema.company_namecolumn = txtCompanyNameColumn.Text;
            _formSchema.date_column = txtDateColumn.Text;
            _formSchema.sqlstatementsecondaries = txtSQLSecondary.Text;
            _formSchema.sqlstatementpredeterms = txtSQLPredeterm.Text;
            _formSchema.claim_db_column = txtClaimDBColumn.Text;
            _formSchema.sqlstatementsecondarypredeterms = txtSQLSecondaryPredeterm.Text;

            if (chkAllowSavePassword.Checked)
            {
                _formSchema.pw = txtPassword.Text;
            }
            else
                _formSchema.pw = "";

            #endregion
            _formSchema.Save();

            _formSchema.ExecuteNonQuery("DELETE FROM data_mapping_schema_data WHERE schema_id = " +
                _formSchema.id);            

            data_mapping_schema_data saveSchemaData;
            foreach (DataGridViewRow aRow in dgvMappings.Rows)
            {
                if (CommonFunctions.DBNullToString(aRow.Cells["colLinkedField"].Value) != "")
                {
                    // Save this
                    saveSchemaData = new data_mapping_schema_data();
                    saveSchemaData.mapping_field_id = ((data_mapping_field)aRow.Cells["colFieldData"].Value).id;
                    saveSchemaData.mapped_to_text = aRow.Cells["colLinkedField"].Value.ToString();
                    saveSchemaData.schema_id = _formSchema.id;

                    saveSchemaData.Save();
                }
            }
            _dataChanged = false;
        }

        private void txtSchemaName_TextChanged(object sender, EventArgs e)
        {
            Text = "Configure Schema: " + txtSchemaName.Text;
        }

        private void cmbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDataType.SelectedIndex == 0)
            {
                pnlSQLDataType.Visible = true;
            }
            else
            {
                MessageBox.Show(this, "Selected type is not supported yet.", "Unsupported type");
                cmbDataType.SelectedIndex = 0;
            }
            _dataChanged = true;
        }

        private void chkAllowSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Visible = chkAllowSavePassword.Checked;
            lblPassword.Visible = chkAllowSavePassword.Checked;
            _dataChanged = true;
        }

        private void frmConfigureSchema_Load(object sender, EventArgs e)
        {

        }

        private void text_changed(object sender, EventArgs e)
        {
            _dataChanged = true;
        }

        private void dgvMappings_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _dataChanged = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            if (RecordChangeOK())
            {
                Close();
            }
        }
    }

    public class FieldMappingDisplay
    {
        private string _fieldName;
        private string _linkedField;
        private string _tableName;
        private data_mapping_field _fieldData;

        public FieldMappingDisplay()
        { }

        public string FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        public string LinkedField
        {
            get { return _linkedField; }
            set { _linkedField = value; }
        }
        public data_mapping_field FieldData
        {
            get { return _fieldData; }
            set { _fieldData = value; }
        }

    }
}