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
    public partial class DisplayPariu : Form
    {
       
        List<Pariu> pariuri = new List<Pariu>();
        List<Client> clienti = new List<Client>();
        List<Meci> meciuri = new List<Meci>();
        public DisplayPariu(List<Client> clienti, List<Meci> meciuri, List<Pariu> pariuri)
        {
            InitializeComponent();
            this.pariuri = pariuri;
            this.clienti = clienti;
            this.meciuri = meciuri;
            populare();
        }
        private void populare()
        {

            listView1.Items.Clear();
            foreach (Pariu p in pariuri)
            {
                ListViewItem itm = new ListViewItem(p.NumeClient);
                itm.SubItems.Add(p.Cota.ToString());
                itm.SubItems.Add(p.LocatieMeci);
                itm.SubItems.Add(p.SumaPariata.ToString());
                itm.Tag = p;
                listView1.Items.Add(itm);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditPariu frm = new EditPariu(clienti,meciuri,(Pariu)listView1.SelectedItems[0].Tag);
            frm.ShowDialog();
            populare();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Pariu p = (Pariu)listView1.SelectedItems[0].Tag;
            pariuri.Remove(p);
            populare();
        }
    }
}
