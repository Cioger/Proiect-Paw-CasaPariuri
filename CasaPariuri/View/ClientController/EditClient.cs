using CasaPariuri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaPariuri.View.ClientController
{
    public partial class EditClient : Form
    {
        Client c;
        public EditClient(Client c)
        {
            InitializeComponent();
            this.c = c;
            rtbNume.Text = c.Nume;
            rtbVarsta.Text = c.Varsta.ToString();
            rtbTelefon.Text = c.Telefon.ToString();
            rtbMail.Text = c.Mail;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbNume.Text))
                {
                    errorProvider1.SetError(rtbNume, "Introduceti numele!");
                }
                else
                if (string.IsNullOrEmpty(rtbVarsta.Text))
                {
                    errorProvider1.SetError(rtbVarsta, "Introduceti varsta!");
                }
                else
                if (string.IsNullOrEmpty(rtbTelefon.Text))
                {
                    errorProvider1.SetError(rtbTelefon, "Introduceti telefonul!");
                }
                else
                if (string.IsNullOrEmpty(rtbMail.Text))
                {
                    errorProvider1.SetError(rtbMail, "Introduceti mailul!");
                }
                else
                {
                    c.Nume = rtbNume.Text;
                    c.Varsta = Convert.ToInt32(rtbVarsta.Text);
                    c.Telefon = Convert.ToInt32(rtbTelefon.Text);
                    c.Mail = rtbMail.Text;
                    MessageBox.Show("Client modificat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

     
    }
}
