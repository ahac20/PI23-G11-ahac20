namespace Evaluation_Manager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uvjetZaPotpis = new System.Windows.Forms.Label();
            this.uvjetZaOcjenu = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.aktivnosti = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datumEvaluacije = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // uvjetZaPotpis
            // 
            this.uvjetZaPotpis.AutoSize = true;
            this.uvjetZaPotpis.Location = new System.Drawing.Point(545, 9);
            this.uvjetZaPotpis.Name = "uvjetZaPotpis";
            this.uvjetZaPotpis.Size = new System.Drawing.Size(77, 13);
            this.uvjetZaPotpis.TabIndex = 0;
            this.uvjetZaPotpis.Text = "Uvjet za potpis";
            this.uvjetZaPotpis.Click += new System.EventHandler(this.label1_Click);
            // 
            // uvjetZaOcjenu
            // 
            this.uvjetZaOcjenu.AutoSize = true;
            this.uvjetZaOcjenu.Location = new System.Drawing.Point(688, 9);
            this.uvjetZaOcjenu.Name = "uvjetZaOcjenu";
            this.uvjetZaOcjenu.Size = new System.Drawing.Size(81, 13);
            this.uvjetZaOcjenu.TabIndex = 1;
            this.uvjetZaOcjenu.Text = "Uvjet za ocjenu";
            this.uvjetZaOcjenu.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(34, 26);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(121, 21);
            this.cboActivities.TabIndex = 2;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // aktivnosti
            // 
            this.aktivnosti.AutoSize = true;
            this.aktivnosti.Location = new System.Drawing.Point(12, 9);
            this.aktivnosti.Name = "aktivnosti";
            this.aktivnosti.Size = new System.Drawing.Size(51, 13);
            this.aktivnosti.TabIndex = 3;
            this.aktivnosti.Text = "Aktivnost";
            this.aktivnosti.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(522, 27);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
            this.txtMinForSignature.TabIndex = 4;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(669, 27);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
            this.txtMinForGrade.TabIndex = 5;
            this.txtMinForGrade.TextChanged += new System.EventHandler(this.txtMinForGrade_TextChanged);
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(53, 110);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(696, 139);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Location = new System.Drawing.Point(351, 293);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(57, 13);
            this.teacher.TabIndex = 7;
            this.teacher.Text = "Ocjenjivač";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(308, 318);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // datumEvaluacije
            // 
            this.datumEvaluacije.AutoSize = true;
            this.datumEvaluacije.Location = new System.Drawing.Point(487, 293);
            this.datumEvaluacije.Name = "datumEvaluacije";
            this.datumEvaluacije.Size = new System.Drawing.Size(89, 13);
            this.datumEvaluacije.TabIndex = 10;
            this.datumEvaluacije.Text = "Datum evaluacije";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(691, 319);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(45, 20);
            this.numPoints.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Number";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(691, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.datumEvaluacije);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.aktivnosti);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.uvjetZaOcjenu);
            this.Controls.Add(this.uvjetZaPotpis);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uvjetZaPotpis;
        private System.Windows.Forms.Label uvjetZaOcjenu;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label aktivnosti;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label datumEvaluacije;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}