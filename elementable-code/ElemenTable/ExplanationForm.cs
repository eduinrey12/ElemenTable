using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace ElemenTable
{
    public partial class ExplanationForm : Form
    {

        public ExplanationForm(Dictionary<string, Color> ColorGroup)
        {
            InitializeComponent();
            ResourceManager res = new ResourceManager("ElemenTable.Properties.Resources", typeof(MainForm).Assembly);
            foreach (KeyValuePair<string, Color> group in ColorGroup)
            {
                Label lblName = new Label();
                lblName.Dock = DockStyle.Fill;
                lblName.Size = new Size(98, 30);
                lblName.TextAlign = ContentAlignment.MiddleLeft;
                string res_txt = res.GetString(group.Key);
                if (res_txt != null) lblName.Text = res_txt;
                else lblName.Text = group.Key;
                Panel panColor = new Panel();
                panColor.Dock = DockStyle.Fill;
                panColor.Size = new Size(18, 24);
                panColor.BackColor = group.Value;
                tlpElements.Controls.Add(panColor);
                tlpElements.Controls.Add(lblName);
            }
        }
    }
}
