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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private CatForm frmCat;
        private OwnerForm frmOwner;
        private TreatmentForm frmTreatment;
        private VisitForm frmVisit;
        private VisitTreatmentForm frmVisitTreatment;
        private InvoiceForm frmInvoice;
        private VeterinarianForm frmVeterinarian;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }
       
      
        private void btTreatment_Click_1(object sender, EventArgs e)
        {
            if (frmTreatment == null)
            {
                frmTreatment = new TreatmentForm(DM, this);
            }
            frmTreatment.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
