namespace CasaPariuri.View.MeciController
{
    partial class EditMeci
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
            this.rtbLocatie = new System.Windows.Forms.RichTextBox();
            this.rtbAcasa = new System.Windows.Forms.RichTextBox();
            this.rtbDeplasare = new System.Windows.Forms.RichTextBox();
            this.cbDurata = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbLocatie
            // 
            this.rtbLocatie.Location = new System.Drawing.Point(60, 91);
            this.rtbLocatie.Name = "rtbLocatie";
            this.rtbLocatie.Size = new System.Drawing.Size(205, 37);
            this.rtbLocatie.TabIndex = 12;
            this.rtbLocatie.Text = "";
            // 
            // rtbAcasa
            // 
            this.rtbAcasa.Location = new System.Drawing.Point(60, 167);
            this.rtbAcasa.Name = "rtbAcasa";
            this.rtbAcasa.Size = new System.Drawing.Size(205, 37);
            this.rtbAcasa.TabIndex = 13;
            this.rtbAcasa.Text = "";
            // 
            // rtbDeplasare
            // 
            this.rtbDeplasare.Location = new System.Drawing.Point(60, 244);
            this.rtbDeplasare.Name = "rtbDeplasare";
            this.rtbDeplasare.Size = new System.Drawing.Size(205, 37);
            this.rtbDeplasare.TabIndex = 14;
            this.rtbDeplasare.Text = "";
            // 
            // cbDurata
            // 
            this.cbDurata.FormattingEnabled = true;
            this.cbDurata.Items.AddRange(new object[] {
            "60",
            "90",
            "120"});
            this.cbDurata.Location = new System.Drawing.Point(60, 328);
            this.cbDurata.Name = "cbDurata";
            this.cbDurata.Size = new System.Drawing.Size(205, 24);
            this.cbDurata.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(110, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 48);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Locatia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Echipa Acasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Echipa Deplasare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Durata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Editare Meci";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditMeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbDurata);
            this.Controls.Add(this.rtbDeplasare);
            this.Controls.Add(this.rtbAcasa);
            this.Controls.Add(this.rtbLocatie);
            this.Name = "EditMeci";
            this.Text = "EditMeci";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLocatie;
        private System.Windows.Forms.RichTextBox rtbAcasa;
        private System.Windows.Forms.RichTextBox rtbDeplasare;
        private System.Windows.Forms.ComboBox cbDurata;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}