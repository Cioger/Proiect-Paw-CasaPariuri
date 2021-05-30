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

    public partial class DisplayMeci : Form
    {
        List<Meci> meciuri = new List<Meci>();
        public DisplayMeci(List<Meci> meciuri)
        {
            InitializeComponent();
            this.meciuri = meciuri;
            populare();
        }
        private void populare()
        {

            listView1.Items.Clear();
            foreach (Meci m in meciuri)
            {
                ListViewItem itm = new ListViewItem(m.Locatie);
                itm.SubItems.Add(m.EchipaAcasa);
                itm.SubItems.Add(m.EchipaDeplasare);
                itm.SubItems.Add(m.Durata.ToString());
                itm.Tag = m;
                listView1.Items.Add(itm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Meci m = (Meci)listView1.SelectedItems[0].Tag;
            meciuri.Remove(m);
            populare();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditMeci frm = new EditMeci((Meci)listView1.SelectedItems[0].Tag);
            frm.ShowDialog();
            populare();
        }
    }
}
