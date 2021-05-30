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
    public partial class DisplayClient : Form
    {
        List<Client> clienti = new List<Client>();
        public DisplayClient(List<Client> clienti)
        {
            InitializeComponent();
            this.clienti = clienti;
            populare();
        }
        private void populare()
        {
           
            listView1.Items.Clear();
            foreach (Client c in clienti)
            {
                ListViewItem itm = new ListViewItem(c.Nume);
                itm.SubItems.Add(c.Varsta.ToString());
                itm.SubItems.Add(c.Telefon.ToString());
                itm.SubItems.Add(c.Mail);
                itm.Tag = c;
                listView1.Items.Add(itm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Client c = (Client)listView1.SelectedItems[0].Tag;
            clienti.Remove(c);
            populare();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditClient frm = new EditClient((Client)listView1.SelectedItems[0].Tag);
            frm.ShowDialog();
            populare();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client c = (Client)listView1.SelectedItems[0].Tag;
            clienti.Remove(c);
            populare();
        }
    }
}
