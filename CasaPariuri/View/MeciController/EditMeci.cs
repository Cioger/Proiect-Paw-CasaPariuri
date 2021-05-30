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

namespace CasaPariuri.View.MeciController
{
    public partial class EditMeci : Form
    {
        Meci m;
        public EditMeci(Meci m)
        {
            InitializeComponent();
            this.m = m;
            rtbLocatie.Text = m.Locatie;
            rtbAcasa.Text = m.EchipaAcasa;
            rtbDeplasare.Text = m.EchipaDeplasare;
            cbDurata.Text = m.Durata.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbLocatie.Text))
                {
                    errorProvider1.SetError(rtbLocatie, "Introduceti Locatia!");
                }
                else
                if (string.IsNullOrEmpty(rtbAcasa.Text))
                {
                    errorProvider1.SetError(rtbAcasa, "Introduceti echipa acasa!");
                }
                else
                if (string.IsNullOrEmpty(rtbDeplasare.Text))
                {
                    errorProvider1.SetError(rtbDeplasare, "Introduceti echipa deplasare!");
                }
                else
                if (string.IsNullOrEmpty(cbDurata.Text))
                {
                    errorProvider1.SetError(cbDurata, "Selectati durata!");
                }
                else
                {
                    m.Locatie = rtbLocatie.Text;
                    m.EchipaAcasa = rtbAcasa.Text;
                    m.EchipaDeplasare = rtbDeplasare.Text;
                    m.Durata = Convert.ToInt32(cbDurata.Text);
                    MessageBox.Show("Meci modificat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
