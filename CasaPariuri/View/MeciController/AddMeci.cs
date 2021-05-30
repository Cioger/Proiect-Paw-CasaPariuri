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
    public partial class AddMeci : Form
    {
        List<Meci> meciuri = new List<Meci>();
        public AddMeci(List<Meci> meciuri)
        {
            InitializeComponent();
            this.meciuri = meciuri;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbLocatie.Text))
                {
                    errorProvider1.SetError(rtbLocatie, "Introduceti locatia!");
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
                    string locatie = rtbLocatie.Text;
                    string acasa = rtbAcasa.Text;
                    string deplasare = rtbDeplasare.Text;
                    int durata = Convert.ToInt32(cbDurata.Text);
                    Meci m = new Meci(acasa,deplasare,durata,locatie);
                    meciuri.Add(m);
                    MessageBox.Show("Meci adaugat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rtbLocatie.Clear();
                rtbAcasa.Clear();
                rtbDeplasare.Clear();
            }
        }

        private void emptyFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbLocatie.Clear();
            rtbAcasa.Clear();
            rtbDeplasare.Clear();
        }
    }
}
