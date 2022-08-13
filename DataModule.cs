using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjectGlendene
{
    public partial class DataModule : Form
    {
        public DataTable dtCat;
        public DataTable dtOwner;
        public DataTable dtVeterinarian;
        public DataTable dtTreatment;
        public DataTable dtVisit;
        public DataTable dtVisitTreatment;
        public DataTable catView;
        public DataTable treatmentView;
        public DataTable ownerView;
        public DataTable veterinarianView;
        public DataTable visitView;
        public DataTable vistTreatmentView;


        public DataModule()
        {
            InitializeComponent();
            dsGlendene.EnforceConstraints = false;
            daCat.Fill(dsGlendene);
            daOwner.Fill(dsGlendene);   
            daVisitTreatment.Fill(dsGlendene);
            daTreatment.Fill(dsGlendene);
            dtCat = dsGlendene.Tables["Cat"];
            dtOwner = dsGlendene.Tables["Owner"];
            dtTreatment = dsGlendene.Tables["Treatment"];
            dtVeterinarian = dsGlendene.Tables["Veterinarian"];
            dtVisitTreatment = dsGlendene.Tables["VistTreatment"];
            dtVisit = dsGlendene.Tables["Vist"];
            dsGlendene.EnforceConstraints = true;

        }
        public void UpdateTreatment()
        {
            daTreatment.Update(dtTreatment);
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void oleDbConnection1_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }
    }
}
