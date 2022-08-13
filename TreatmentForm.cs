using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGlendene
{
    public partial class TreatmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public TreatmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();

        }

        private void TreatmentForm_Load(object sender, EventArgs e)
        {

        }
        public void BindControls() {
            
                lblTreatmentID.DataBindings.Add("Text", DM.dsGlendene, "Treatment.TreatmentID");
                txtDescription.DataBindings.Add("Text", DM.dsGlendene, "Treatment.Description");

                txtCost.DataBindings.Add("Text", DM.dsGlendene, "Treatment.Cost");
                lstTreatments.DataSource = DM.dsGlendene;
                lstTreatments.DisplayMember = "Treatment.Description";
                lstTreatments.ValueMember = "Treatment.Description";

            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGlendene, "TREATMENT"];

            
        } 
        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        private void btnNext_click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btPrevious_Click_1(object sender, EventArgs e)
        {

        }
    }
}
