namespace CasaPariuri.View.MeciController
{
    partial class AddMeci
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
            this.label5 = new System.Windows.Forms.Label();
            this.rtbLocatie = new System.Windows.Forms.RichTextBox();
            this.rtbAcasa = new System.Windows.Forms.RichTextBox();
            this.rtbDeplasare = new System.Windows.Forms.RichTextBox();
            this.cbDurata = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.emptyFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adaugare Meci";
            // 
            // rtbLocatie
            // 
            this.rtbLocatie.Location = new System.Drawing.Point(65, 87);
            this.rtbLocatie.Name = "rtbLocatie";
            this.rtbLocatie.Size = new System.Drawing.Size(205, 37);
            this.rtbLocatie.TabIndex = 11;
            this.rtbLocatie.Text = "";
            // 
            // rtbAcasa
            // 
            this.rtbAcasa.Location = new System.Drawing.Point(65, 169);
            this.rtbAcasa.Name = "rtbAcasa";
            this.rtbAcasa.Size = new System.Drawing.Size(205, 37);
            this.rtbAcasa.TabIndex = 12;
            this.rtbAcasa.Text = "";
            // 
            // rtbDeplasare
            // 
            this.rtbDeplasare.Location = new System.Drawing.Point(65, 243);
            this.rtbDeplasare.Name = "rtbDeplasare";
            this.rtbDeplasare.Size = new System.Drawing.Size(205, 37);
            this.rtbDeplasare.TabIndex = 13;
            this.rtbDeplasare.Text = "";
            // 
            // cbDurata
            // 
            this.cbDurata.FormattingEnabled = true;
            this.cbDurata.Items.AddRange(new object[] {
            "60",
            "90",
            "120"});
            this.cbDurata.Location = new System.Drawing.Point(65, 319);
            this.cbDurata.Name = "cbDurata";
            this.cbDurata.Size = new System.Drawing.Size(205, 24);
            this.cbDurata.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Locatia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Echipa Acasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Echipa Deplasare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Durata";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(119, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 48);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyFieldsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 28);
            // 
            // emptyFieldsToolStripMenuItem
            // 
            this.emptyFieldsToolStripMenuItem.Name = "emptyFieldsToolStripMenuItem";
            this.emptyFieldsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.emptyFieldsToolStripMenuItem.Text = "Empty Fields";
            this.emptyFieldsToolStripMenuItem.Click += new System.EventHandler(this.emptyFieldsToolStripMenuItem_Click);
            // 
            // AddMeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDurata);
            this.Controls.Add(this.rtbDeplasare);
            this.Controls.Add(this.rtbAcasa);
            this.Controls.Add(this.rtbLocatie);
            this.Controls.Add(this.label5);
            this.Name = "AddMeci";
            this.Text = "AddMeci";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbLocatie;
        private System.Windows.Forms.RichTextBox rtbAcasa;
        private System.Windows.Forms.RichTextBox rtbDeplasare;
        private System.Windows.Forms.ComboBox cbDurata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emptyFieldsToolStripMenuItem;
    }
}