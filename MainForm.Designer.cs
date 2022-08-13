namespace ProjectGlendene
{
    partial class MainForm
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
            this.groupMaintenance = new System.Windows.Forms.GroupBox();
            this.btTreatmentVisit = new System.Windows.Forms.Button();
            this.btVisitor = new System.Windows.Forms.Button();
            this.btTreatment = new System.Windows.Forms.Button();
            this.btCat = new System.Windows.Forms.Button();
            this.btVeterinarian = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btInvoices = new System.Windows.Forms.Button();
            this.groupMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMaintenance
            // 
            this.groupMaintenance.Controls.Add(this.btTreatmentVisit);
            this.groupMaintenance.Controls.Add(this.btVisitor);
            this.groupMaintenance.Controls.Add(this.btTreatment);
            this.groupMaintenance.Controls.Add(this.btCat);
            this.groupMaintenance.Controls.Add(this.btVeterinarian);
            this.groupMaintenance.Controls.Add(this.btnOwner);
            this.groupMaintenance.Location = new System.Drawing.Point(52, 35);
            this.groupMaintenance.Name = "groupMaintenance";
            this.groupMaintenance.Size = new System.Drawing.Size(323, 349);
            this.groupMaintenance.TabIndex = 0;
            this.groupMaintenance.TabStop = false;
            this.groupMaintenance.Text = "Maintenance";
            // 
            // btTreatmentVisit
            // 
            this.btTreatmentVisit.Location = new System.Drawing.Point(24, 255);
            this.btTreatmentVisit.Name = "btTreatmentVisit";
            this.btTreatmentVisit.Size = new System.Drawing.Size(269, 38);
            this.btTreatmentVisit.TabIndex = 5;
            this.btTreatmentVisit.Text = "Allocate Treatment to visit";
            this.btTreatmentVisit.UseVisualStyleBackColor = true;
            // 
            // btVisitor
            // 
            this.btVisitor.Location = new System.Drawing.Point(24, 211);
            this.btVisitor.Name = "btVisitor";
            this.btVisitor.Size = new System.Drawing.Size(269, 38);
            this.btVisitor.TabIndex = 4;
            this.btVisitor.Text = "Visit Maintenance";
            this.btVisitor.UseVisualStyleBackColor = true;
            // 
            // btTreatment
            // 
            this.btTreatment.Location = new System.Drawing.Point(24, 167);
            this.btTreatment.Name = "btTreatment";
            this.btTreatment.Size = new System.Drawing.Size(269, 38);
            this.btTreatment.TabIndex = 3;
            this.btTreatment.Text = "Treatment Maintenance";
            this.btTreatment.UseVisualStyleBackColor = true;
            this.btTreatment.Click += new System.EventHandler(this.btTreatment_Click_1);
            // 
            // btCat
            // 
            this.btCat.Location = new System.Drawing.Point(24, 123);
            this.btCat.Name = "btCat";
            this.btCat.Size = new System.Drawing.Size(269, 38);
            this.btCat.TabIndex = 2;
            this.btCat.Text = "Cat Maintenance";
            this.btCat.UseVisualStyleBackColor = true;
            // 
            // btVeterinarian
            // 
            this.btVeterinarian.Location = new System.Drawing.Point(24, 79);
            this.btVeterinarian.Name = "btVeterinarian";
            this.btVeterinarian.Size = new System.Drawing.Size(269, 38);
            this.btVeterinarian.TabIndex = 1;
            this.btVeterinarian.Text = "Veterinarian Maintenance";
            this.btVeterinarian.UseVisualStyleBackColor = true;
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(24, 35);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(269, 38);
            this.btnOwner.TabIndex = 0;
            this.btnOwner.Text = "Owner Maintenance";
            this.btnOwner.UseVisualStyleBackColor = true;
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btExit);
            this.grpReport.Controls.Add(this.btInvoices);
            this.grpReport.Location = new System.Drawing.Point(442, 35);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(346, 349);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(47, 255);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(272, 38);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btInvoices
            // 
            this.btInvoices.Location = new System.Drawing.Point(47, 35);
            this.btInvoices.Name = "btInvoices";
            this.btInvoices.Size = new System.Drawing.Size(272, 38);
            this.btInvoices.TabIndex = 2;
            this.btInvoices.Text = "Invoices";
            this.btInvoices.UseVisualStyleBackColor = true;
            this.btInvoices.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.groupMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMaintenance;
        private System.Windows.Forms.Button btTreatmentVisit;
        private System.Windows.Forms.Button btVisitor;
        private System.Windows.Forms.Button btTreatment;
        private System.Windows.Forms.Button btCat;
        private System.Windows.Forms.Button btVeterinarian;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btInvoices;
    }
}

