namespace WF_Adressverwaltung
{
    partial class frmAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbxStadt = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbxCountry = new System.Windows.Forms.ComboBox();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.AnschriftID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StraßeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WohnungNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LandtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxStreetName = new System.Windows.Forms.TextBox();
            this.txtbxWohnungNr = new System.Windows.Forms.TextBox();
            this.txtbxPostCode = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblWohnungNr = new System.Windows.Forms.Label();
            this.lblPLZ = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.dB_AddressDataSet = new WF_Adressverwaltung.DB_AddressDataSet();
            this.anschriftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anschriftTableAdapter = new WF_Adressverwaltung.DB_AddressDataSetTableAdapters.AnschriftTableAdapter();
            this.anschriftBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AddressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anschriftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anschriftBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxStadt
            // 
            this.cmbxStadt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxStadt.FormattingEnabled = true;
            this.cmbxStadt.Location = new System.Drawing.Point(119, 248);
            this.cmbxStadt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbxStadt.Name = "cmbxStadt";
            this.cmbxStadt.Size = new System.Drawing.Size(244, 28);
            this.cmbxStadt.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(139, 348);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sparen";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(3, 350);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(256, 348);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbxCountry
            // 
            this.cmbxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCountry.FormattingEnabled = true;
            this.cmbxCountry.Location = new System.Drawing.Point(119, 299);
            this.cmbxCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbxCountry.Name = "cmbxCountry";
            this.cmbxCountry.Size = new System.Drawing.Size(244, 28);
            this.cmbxCountry.TabIndex = 3;
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddress.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnschriftID,
            this.StraßeName,
            this.WohnungNr,
            this.PLZ,
            this.Stadt,
            this.Land,
            this.StadtId,
            this.LandtId,
            this.HashCode});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddress.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAddress.Location = new System.Drawing.Point(395, 12);
            this.dgvAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAddress.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvAddress.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAddress.RowTemplate.Height = 24;
            this.dgvAddress.Size = new System.Drawing.Size(677, 378);
            this.dgvAddress.TabIndex = 4;
            this.dgvAddress.DoubleClick += new System.EventHandler(this.dgvAddress_DoubleClick);
            // 
            // AnschriftID
            // 
            this.AnschriftID.DataPropertyName = "AnschriftID";
            this.AnschriftID.HeaderText = "AnschriftID";
            this.AnschriftID.MinimumWidth = 6;
            this.AnschriftID.Name = "AnschriftID";
            this.AnschriftID.ReadOnly = true;
            this.AnschriftID.Visible = false;
            this.AnschriftID.Width = 125;
            // 
            // StraßeName
            // 
            this.StraßeName.DataPropertyName = "StraßeName";
            this.StraßeName.HeaderText = "Straße";
            this.StraßeName.MinimumWidth = 6;
            this.StraßeName.Name = "StraßeName";
            this.StraßeName.ReadOnly = true;
            this.StraßeName.Width = 125;
            // 
            // WohnungNr
            // 
            this.WohnungNr.DataPropertyName = "WohnungNummer";
            this.WohnungNr.HeaderText = "Wohnung Nr.";
            this.WohnungNr.MinimumWidth = 6;
            this.WohnungNr.Name = "WohnungNr";
            this.WohnungNr.ReadOnly = true;
            this.WohnungNr.Width = 125;
            // 
            // PLZ
            // 
            this.PLZ.DataPropertyName = "PLZ";
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.MinimumWidth = 6;
            this.PLZ.Name = "PLZ";
            this.PLZ.ReadOnly = true;
            this.PLZ.Width = 125;
            // 
            // Stadt
            // 
            this.Stadt.DataPropertyName = "Stadt";
            this.Stadt.HeaderText = "Stadt";
            this.Stadt.MinimumWidth = 6;
            this.Stadt.Name = "Stadt";
            this.Stadt.ReadOnly = true;
            this.Stadt.Width = 125;
            // 
            // Land
            // 
            this.Land.DataPropertyName = "Land";
            this.Land.HeaderText = "Land";
            this.Land.MinimumWidth = 6;
            this.Land.Name = "Land";
            this.Land.ReadOnly = true;
            this.Land.Width = 125;
            // 
            // StadtId
            // 
            this.StadtId.HeaderText = "StadtId";
            this.StadtId.MinimumWidth = 6;
            this.StadtId.Name = "StadtId";
            this.StadtId.ReadOnly = true;
            this.StadtId.Visible = false;
            this.StadtId.Width = 125;
            // 
            // LandtId
            // 
            this.LandtId.HeaderText = "LandtId";
            this.LandtId.MinimumWidth = 6;
            this.LandtId.Name = "LandtId";
            this.LandtId.ReadOnly = true;
            this.LandtId.Visible = false;
            this.LandtId.Width = 125;
            // 
            // HashCode
            // 
            this.HashCode.DataPropertyName = "HashCode";
            this.HashCode.HeaderText = "HashCode";
            this.HashCode.MinimumWidth = 6;
            this.HashCode.Name = "HashCode";
            this.HashCode.ReadOnly = true;
            this.HashCode.Visible = false;
            this.HashCode.Width = 125;
            // 
            // txtbxStreetName
            // 
            this.txtbxStreetName.Location = new System.Drawing.Point(15, 70);
            this.txtbxStreetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbxStreetName.Multiline = true;
            this.txtbxStreetName.Name = "txtbxStreetName";
            this.txtbxStreetName.Size = new System.Drawing.Size(348, 59);
            this.txtbxStreetName.TabIndex = 5;
            // 
            // txtbxWohnungNr
            // 
            this.txtbxWohnungNr.Location = new System.Drawing.Point(186, 149);
            this.txtbxWohnungNr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbxWohnungNr.Name = "txtbxWohnungNr";
            this.txtbxWohnungNr.Size = new System.Drawing.Size(174, 28);
            this.txtbxWohnungNr.TabIndex = 6;
            // 
            // txtbxPostCode
            // 
            this.txtbxPostCode.Location = new System.Drawing.Point(119, 197);
            this.txtbxPostCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtbxPostCode.Name = "txtbxPostCode";
            this.txtbxPostCode.Size = new System.Drawing.Size(244, 28);
            this.txtbxPostCode.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(50, 299);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(45, 20);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Land";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(15, 45);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(108, 20);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Straße Name";
            // 
            // lblWohnungNr
            // 
            this.lblWohnungNr.AutoSize = true;
            this.lblWohnungNr.Location = new System.Drawing.Point(14, 152);
            this.lblWohnungNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWohnungNr.Name = "lblWohnungNr";
            this.lblWohnungNr.Size = new System.Drawing.Size(161, 20);
            this.lblWohnungNr.TabIndex = 10;
            this.lblWohnungNr.Text = "Straße/Wohnung Nr.";
            // 
            // lblPLZ
            // 
            this.lblPLZ.AutoSize = true;
            this.lblPLZ.Location = new System.Drawing.Point(59, 203);
            this.lblPLZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPLZ.Name = "lblPLZ";
            this.lblPLZ.Size = new System.Drawing.Size(39, 20);
            this.lblPLZ.TabIndex = 11;
            this.lblPLZ.Text = "PLZ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(50, 251);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 20);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Stadt";
            // 
            // dB_AddressDataSet
            // 
            this.dB_AddressDataSet.DataSetName = "DB_AddressDataSet";
            this.dB_AddressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anschriftBindingSource
            // 
            this.anschriftBindingSource.DataMember = "Anschrift";
            this.anschriftBindingSource.DataSource = this.dB_AddressDataSet;
            // 
            // anschriftTableAdapter
            // 
            this.anschriftTableAdapter.ClearBeforeFill = true;
            // 
            // anschriftBindingSource1
            // 
            this.anschriftBindingSource1.DataMember = "Anschrift";
            this.anschriftBindingSource1.DataSource = this.dB_AddressDataSet;
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1085, 434);
            this.Controls.Add(this.cmbxStadt);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblPLZ);
            this.Controls.Add(this.lblWohnungNr);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtbxPostCode);
            this.Controls.Add(this.txtbxWohnungNr);
            this.Controls.Add(this.txtbxStreetName);
            this.Controls.Add(this.dgvAddress);
            this.Controls.Add(this.cmbxCountry);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddress";
            this.Text = "Adressverwaltung";
            this.Load += new System.EventHandler(this.frmAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_AddressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anschriftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anschriftBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbxCountry;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.TextBox txtbxStreetName;
        private System.Windows.Forms.TextBox txtbxWohnungNr;
        private System.Windows.Forms.TextBox txtbxPostCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblWohnungNr;
        private System.Windows.Forms.Label lblPLZ;
        private System.Windows.Forms.Label lblCity;
        private DB_AddressDataSet dB_AddressDataSet;
        private System.Windows.Forms.BindingSource anschriftBindingSource;
        private DB_AddressDataSetTableAdapters.AnschriftTableAdapter anschriftTableAdapter;
        private System.Windows.Forms.BindingSource anschriftBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnschriftID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StraßeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WohnungNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Land;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LandtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashCode;
        private System.Windows.Forms.ComboBox cmbxStadt;
    }
}

