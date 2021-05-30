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
    public partial class AddClient : Form
    {
        List<Client> clienti = new List<Client>();
        public AddClient(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
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
                    string nume = rtbNume.Text;
                    int varsta = Convert.ToInt32(rtbVarsta.Text);
                    int telefon = Convert.ToInt32(rtbTelefon.Text);
                    string mail = rtbMail.Text;
                    Client c = new Client(nume,varsta,telefon,mail);
                    clienti.Add(c);
                    MessageBox.Show("Client adaugat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rtbNume.Clear();
                rtbVarsta.Clear();
                rtbTelefon.Clear();
                rtbMail.Clear();
            }

        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbNume.Clear();
            rtbVarsta.Clear();
            rtbTelefon.Clear();
            rtbMail.Clear();
        }
    }
}
