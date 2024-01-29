using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Bluegrams.Periodica.Data;

namespace ElemenTable
{
    public partial class SearchForm : Form
    {
        TableManager ptemanager;

        public SearchForm(TableManager ptemanager)
        {
            this.ptemanager = ptemanager;
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            lstElements.Sorted = true;
            foreach (Element elem in ptemanager.PeriodicTable)
            {
                lstElements.Items.Add(elem.LocalizedName);
            }
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            if (lstElements.SelectedIndex != -1)
            {
                MainForm mf = ((MainForm)this.Owner);
                if (mf.infobox != null) { mf.infobox.Close(); mf.infobox = null; }
                Element elem = ptemanager.PeriodicTable.Elements.Values
                    .Where(el => el.LocalizedName == lstElements.SelectedItem.ToString())
                    .First();
                mf.infobox = new ElementForm(ptemanager, elem);
                mf.infobox.Show(this.Owner);
                this.Close();
            }
            else txtSearch.Focus();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                string elemtxt = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtSearch.Text);
                string foundelem = (from string el in lstElements.Items where el.StartsWith(elemtxt) select el).FirstOrDefault();
                if (foundelem != null)
                {
                    lstElements.SelectedItem = foundelem;
                    lstElements.Focus();
                }
                else
                {
                    MessageBox.Show("No matching elements found.");
                    lstElements.SelectedIndex = -1;
                    txtSearch.Text = "";
                    txtSearch.Focus();
                }
            }
            else txtSearch.Focus();
        }
    }
}
