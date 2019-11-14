using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace WF_Adressverwaltung
{
    public partial class frmAddress : Form
    {
        Anschrift anschriftModel = new Anschrift();
        Stadt stadtmodel = new Stadt();
        Country countrymodel = new Country();
        ErrorProvider EP = new ErrorProvider();
        
        public frmAddress()
        {
            InitializeComponent();
        }
        // Delete functions
        private void btnDelete_Click(object sender, EventArgs e)
        {

            deleteEntry();
        }

        void deleteEntry()
        {
            if (MessageBox.Show("Sind Sie sicher, dass Sie den Datensatz löschen wollen?", " Adressverwaltung", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DB_AddressEntities db = new DB_AddressEntities())
                {
                    var entry = db.Entry(anschriftModel);
                    if (entry.State == EntityState.Detached)
                        db.Anschrifts.Attach(anschriftModel);
                    db.Anschrifts.Remove(anschriftModel);
                    db.SaveChanges();
                    clean();
                    MessageBox.Show("Delete Succesfully!");
                }
            }
        }

        //Reset all UI elements
        void clean()
        {
            txtbxPostCode.Text= txtbxWohnungNr.Text  = txtbxStreetName.Text = "";
            btnSave.Text = "Save";
            //btnSave.Enabled = false;
            btnDelete.Enabled = false;
            anschriftModel.AnschriftID = 0;
            cmbxStadt.SelectedValue = 0;
            cmbxCountry.SelectedValue = 0;
            loadGridviewData();
            EP.Clear();
        }
        
        //Load Main Form with UI list Elements
        private void frmAddress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AddressDataSet.Anschrift' table. You can move, or remove it, as needed.
            this.anschriftTableAdapter.Fill(this.dB_AddressDataSet.Anschrift);
            loadGridviewData();
            loadAllCmbx();
        }

        //To validate the TextBox
        private Boolean txtbxValidator(string label)
        {
            ErrorProvider EP = new ErrorProvider();
            TextBox textBox = (TextBox)Controls.Find(string.Format("txtbx{0}", label), false).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Focus();
                //MessageBox.Show("Bitte Schriebe in der " + label +  "!");
                EP.SetError(textBox, label +  " ist Leer!");
                return false;
            }
            return true;
        }

        //To check the country Dropdown initial selection
        Boolean ddlCountryValidator()
        {
            if (cmbxCountry.SelectedIndex < 1)
            {
                EP.SetError(cmbxCountry, "Ein Land ist erforderlich!");
                //e.Cancel = true;
                
                return false;
            }
            return true;
        }

        //To check the City Dropdown initial selection
        Boolean ddlStadtValidator()
        {
            if (cmbxStadt.SelectedIndex < 1)
            {
                EP.SetError(cmbxStadt, "Ein Stadt ist erforderlich!");
                //e.Cancel = true;
                return false;
            }
            return true;
        }

        //set Data model from user interacted UI components values
        Boolean initializeDataFields()
        {
            bool success = false;
            try
            {
               success = txtbxValidator("StreetName"); 
                if (success) success = txtbxValidator("WohnungNr");
                if (success) success = txtbxValidator("PostCode");
                if (success) success = ddlStadtValidator();
                if (success) success = ddlCountryValidator();
                if (success)
                {
                    // do your save here
                    anschriftModel.StraßeName = txtbxStreetName.Text.Trim(); 
                    anschriftModel.WohnungNummer = txtbxWohnungNr.Text.Trim();
                    anschriftModel.PLZ = txtbxPostCode.Text.Trim(); 
                    if (cmbxStadt.SelectedIndex > -1)
                        anschriftModel.StadtId = (int)cmbxStadt.SelectedValue;
                    if (cmbxCountry.SelectedIndex > -1)
                        anschriftModel.LandId = (int)cmbxCountry.SelectedValue;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return success;
            }
            return success;
        }

        /// <summary>
        /// Used to save and update ; 
        /// Also checked the duplicate data before Insert and Update a entry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (initializeDataFields())
            {
                anschriftModel.HashCode = GetHashCode().ToString();
                if (checkDuplicateEntity(GetHashCode().ToString())) //check duplicacy Entry
                {
                    MessageBox.Show("Data Already Exits!");
                }
                else
                {
                    try
                    {
                        using (DB_AddressEntities db = new DB_AddressEntities())
                        {
                            if (anschriftModel.AnschriftID == 0)//Insert
                                db.Anschrifts.Add(anschriftModel);
                            else//Update
                            {
                                db.Entry(anschriftModel).State = EntityState.Modified;
                                //string s=getHashCode();
                            }


                            db.SaveChanges();
                        }
                        clean();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    loadGridviewData();
                    MessageBox.Show("Submitted Succesfully!");
                }
            }
        }

        //Used to generate the HashCode;
        //mainly created to check item duplicity in a easy way.   
        public override int GetHashCode()
        {
            int hash = 0;
            unchecked //preparing the hashcode
            {
                hash = (txtbxStreetName.Text.Replace(" ", "").Trim().ToLower() == null ? 0 : txtbxStreetName.Text.Replace(" ", "").Trim().ToLower().GetHashCode())
                   ^ (txtbxWohnungNr.Text.Replace(" ", "").Trim().ToLower() == null ? 0 : txtbxWohnungNr.Text.Replace(" ", "").Trim().ToLower().GetHashCode())
                ^ (txtbxPostCode.Text.Replace(" ", "").Trim().ToLower() == null ? 0 : txtbxPostCode.Text.Replace(" ", "").Trim().ToLower().GetHashCode())
                ^ (cmbxStadt.SelectedValue == null ? 0 : cmbxStadt.SelectedValue.GetHashCode())
                ^ (cmbxCountry.SelectedValue == null ? 0 : cmbxCountry.SelectedValue.GetHashCode());
            }
            return hash;
        }

        //Loaded data into Dropdowns
        void loadAllCmbx()
        {
          using (DB_AddressEntities db = new DB_AddressEntities())
            {
                //Land Dropdown
                cmbxCountry.DataSource = db.Countries.ToList();
                cmbxCountry.ValueMember = "CountryID";
                cmbxCountry.DisplayMember = "CountryName";
                cmbxCountry.SelectedValue = 0;

                //Stadt Dropdown
                cmbxStadt.DataSource = db.Stadts.ToList();
                cmbxStadt.ValueMember = "StadtID";
                cmbxStadt.DisplayMember = "StadtName";
                cmbxStadt.SelectedValue = 0;
            }

        }

        // Filled the DataGridView from database which has displayed on form.
        void loadGridviewData()
        {
            dgvAddress.AutoGenerateColumns = false;
            using (DB_AddressEntities db = new DB_AddressEntities())
            {
                var query = (from A in db.Anschrifts
                                   join C in db.Countries on A.LandId equals C.CountryID
                                   join S in db.Stadts on A.StadtId equals S.StadtID
                                   select new {
                                       AnschriftID = A.AnschriftID,
                                       StraßeName=A.StraßeName,
                                       WohnungNummer= A.WohnungNummer,
                                       PLZ=A.PLZ,
                                       Land = C.CountryName,
                                       Stadt = S.StadtName,
                                       StadtId =A.StadtId,
                                       LandId=A.LandId,
                                       HashCode=A.HashCode
                                   }).ToList();
                dgvAddress.DataSource = query;
            }
        }

        //selecte a Item to Update or Delete from VIEW
        private void dgvAddress_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAddress.CurrentRow.Index != -1)
            {
                btnSave.Enabled = true;
                anschriftModel.AnschriftID = Convert.ToInt32(dgvAddress.CurrentRow.Cells["AnschriftID"].Value);
                using(DB_AddressEntities db = new DB_AddressEntities())
                {
                    anschriftModel = db.Anschrifts.Where(x=>x.AnschriftID==anschriftModel.AnschriftID).FirstOrDefault();

                    txtbxPostCode.Text = anschriftModel.PLZ;
                    txtbxWohnungNr.Text = anschriftModel.WohnungNummer;
                    txtbxStreetName.Text = anschriftModel.StraßeName;
                    cmbxStadt.SelectedValue = anschriftModel.StadtId;
                    cmbxCountry.SelectedValue = anschriftModel.LandId;

                    //Generate hashValue
                    //int hashcode=GetHashCode();

                }
                btnDelete.Enabled = true;
                btnSave.Text = "Update";
            }
        }

        // To reset all UI elements 
        private void btnClear_Click(object sender, EventArgs e)
        {
            clean();
        }
        
        //check duplicacy Entry
        public Boolean checkDuplicateEntity(string input)
        {
            String dataHashValue;
            foreach (DataGridViewRow row in dgvAddress.Rows)
            {
                dataHashValue=row.Cells["HashCode"].Value.ToString();
                if (dataHashValue == input)
                {
                    return true;
                }            
            }
            return false;
        }


    }
}
