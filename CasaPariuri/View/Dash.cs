using CasaPariuri.Model;
using CasaPariuri.View.ClientController;
using CasaPariuri.View.MeciController;
using CasaPariuri.View.PariuController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaPariuri.View
{
    public delegate void CallBack(object obj, string path);
    public partial class Dash : Form
    {
        List<Client> clienti = new List<Client>();
        List<Meci> meciuri = new List<Meci>();
        List<Pariu> pariuri = new List<Pariu>();
        private const string clientPath = "clienti.bin";
        private const string meciPath = "meciuri.bin";
        private const string pariuPath = "pariuri.bin";

        public Dash()
        {
            InitializeComponent();
            try
            {
                this.clienti = (List<Client>)Deserialize(clientPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.meciuri = (List<Meci>)Deserialize(meciPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.pariuri = (List<Pariu>)Deserialize(pariuPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dash_Load(object sender, EventArgs e)
        {

        }

        public static void Serialize(object value, string path)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static object Deserialize(string path)
        {
            if (!System.IO.File.Exists(path)) { throw new NotImplementedException(); }

            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream fStream = File.OpenRead(path))
            {
                return formatter.Deserialize(fStream);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient frm = new AddClient(clienti);
            frm.ShowDialog();
        }

        private void btnDisplayClient_Click(object sender, EventArgs e)
        {
            DisplayClient frm = new DisplayClient(clienti);
            frm.ShowDialog();
        }

        private void btnAddMeci_Click(object sender, EventArgs e)
        {
            AddMeci frm = new AddMeci(meciuri);
            frm.ShowDialog();
        }

        private void btnDisplayMeci_Click(object sender, EventArgs e)
        {
            DisplayMeci frm = new DisplayMeci(meciuri);
            frm.ShowDialog();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient frm = new AddClient(clienti);
            frm.ShowDialog();
        }

        private void addMeciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeci frm = new AddMeci(meciuri);
            frm.ShowDialog();
        }

        private void btnAddPariu_Click(object sender, EventArgs e)
        {
            AddPariu frm = new AddPariu(clienti, meciuri, pariuri);
            frm.ShowDialog();
        }

        private void addPariuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPariu frm = new AddPariu(clienti, meciuri, pariuri);
            frm.ShowDialog();
        }

        private void btnDisplayPariu_Click(object sender, EventArgs e)
        {
            DisplayPariu frm = new DisplayPariu(clienti,meciuri,pariuri);
            frm.ShowDialog();
        }
    }
}
