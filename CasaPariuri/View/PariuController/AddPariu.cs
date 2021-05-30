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

namespace CasaPariuri.View.PariuController
{
    public partial class AddPariu : Form
    {
        List<Client> clienti = new List<Client>();
        List<Meci> meciuri = new List<Meci>();
        List<Pariu> pariuri = new List<Pariu>();
        public AddPariu(List<Client> clienti, List<Meci> meciuri, List<Pariu> pariuri)
        {
            InitializeComponent();
            this.clienti = clienti;
            this.meciuri = meciuri;
            this.pariuri = pariuri;
            foreach(Client c in clienti)
            {
                cbClient.Items.Add(c.Nume);
            }
            foreach (Meci m in meciuri)
            {
                cbLocatie.Items.Add(m.Locatie);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbClient.Text))
                {
                    errorProvider1.SetError(cbClient, "Alegeti Clientul!");
                }
                else
                if (string.IsNullOrEmpty(tbCota.Text))
                {
                    errorProvider1.SetError(tbCota, "Introduceti cota!");
                }
                else
                if (string.IsNullOrEmpty(cbLocatie.Text))
                {
                    errorProvider1.SetError(cbLocatie, "Alegeti locatia meciului!");
                }
                else
                if (string.IsNullOrEmpty(tbSuma.Text))
                {
                    errorProvider1.SetError(tbSuma, "Introduceti suma pariata!");
                }
                else
                {
                    string nume = cbClient.Text;
                    float cota = (float)Convert.ToDouble(tbCota.Text);
                    string locatie = cbLocatie.Text;
                    int suma = Convert.ToInt32(tbSuma.Text);
                    Pariu p = new Pariu(nume,cota,locatie,suma);
                    pariuri.Add(p);
                    MessageBox.Show("Pariu adaugat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCota.Clear();
                tbSuma.Clear();
            }
        }
    }
}
