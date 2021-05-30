﻿using CasaPariuri.Model;
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
    public partial class EditPariu : Form
    {
        Pariu p;
        List<Client> clienti = new List<Client>();
        List<Meci> meciuri = new List<Meci>();
        public EditPariu(List<Client> clienti, List<Meci> meciuri, Pariu p)
        {
            InitializeComponent();
            this.p = p;
            this.clienti = clienti;
            this.meciuri = meciuri;
            foreach (Client c in clienti)
            {
                cbClient.Items.Add(c.Nume);
            }
            foreach (Meci m in meciuri)
            {
                cbLocatie.Items.Add(m.Locatie);
            }
            cbClient.Text = p.NumeClient;
            tbCota.Text = p.SumaPariata.ToString();
            cbLocatie.Text = p.LocatieMeci;
            tbSuma.Text = p.SumaPariata.ToString();
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
                    p.NumeClient = cbClient.Text;
                    p.Cota = (float)Convert.ToDouble(tbCota.Text);
                    p.LocatieMeci = cbLocatie.Text;
                    p.SumaPariata = Convert.ToInt32(tbSuma.Text);
                    MessageBox.Show("Pariu modificat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
