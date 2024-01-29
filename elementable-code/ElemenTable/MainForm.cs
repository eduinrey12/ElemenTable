using System;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Bluegrams.Application.WinForms;
using Bluegrams.Periodica.Data;

namespace ElemenTable
{
    public partial class MainForm : Form
    {
        private MiniAppManager manager;
        private const string UPDATE_URL = "https://elementable.sourceforge.io/update.xml";
        private TableManager ptemanager;
        private Button[] elembuttons;
        internal ElementForm infobox;

        public MainForm()
        {
            // Initialize MiniAppManager
            var resourceManager = new ResourceManager(this.GetType());
            var img = (Icon)resourceManager.GetObject("$this.Icon");
            manager = new MiniAppManager(this, true);
            manager.ProductImage = img.ToBitmap();
            manager.Initialize();
            // Initialize window.
            InitializeComponent();
            ptemanager = new TableManager();
            InitializeTable();
        }

        #region MainForm methods

        private void InitializeTable()
        {
            // Create a button for each element.
            elembuttons = new Button[ptemanager.PeriodicTable.Elements.Count];
            for (int i = 0; i < elembuttons.Length; i++)
            {
                Element elem = ptemanager.PeriodicTable[i+1];
                elembuttons[i] = new Button();
                elembuttons[i].Dock = DockStyle.Fill;
                elembuttons[i].FlatAppearance.BorderSize = 3;
                elembuttons[i].FlatStyle = FlatStyle.Flat;
                elembuttons[i].Font = new Font("Arial", 13F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                elembuttons[i].BackColor = ptemanager.GetCurrentColor(elem);
                conViewGroups.Checked = true;
                elembuttons[i].Location = new Point(27, 189);
                //elembuttons[i].Margin = new Padding(2);
                // First three digits of the button name are the atomic number of the element.
                string istring = (i + 1).ToString("000");
                elembuttons[i].Name = istring + "button";
                elembuttons[i].Size = new Size(57  , 60);
                elembuttons[i].TabStop = true;
                elembuttons[i].TabIndex = elem.AtomicNumber;
                elembuttons[i].Text = String.Format("{0}", elem.Symbol);
                //elembuttons[i].Text = String.Format("{0}\n{1}",elem.Symbol, elem.LocalizedName);
                this.quickinfo.SetToolTip(elembuttons[i], elem.LocalizedName);

                Label nelem = new Label();
                nelem.Text = elem.LocalizedName;
                nelem.Font = new Font("Consola", 7.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                nelem.Size = new Size(50, 15);
                nelem.Location = new Point(4, 40);
                elembuttons[i].Controls.Add(nelem);
                elembuttons[i].Click += elem_Click;
                elembuttons[i].GotFocus += elem_Focus;
                int col;
                int row = elem.Period;
                // Put lanthanoids and actionids into separate rows at the bottom.
                if (elem.Group == null || elem.AtomicNumber == 57 || elem.AtomicNumber == 89)
                {
                    if (elem.Period == 6)
                    { row += 3; col = -53 + elem.AtomicNumber; }
                    else
                    { row += 3; col = -85 + elem.AtomicNumber; }
                }
                else col = (int)elem.Group;
                layoutTable.Controls.Add(elembuttons[i], col, row);
            }
            layoutTable.Controls.Add(note_Label("*"), 3, 6);
            layoutTable.Controls.Add(note_Label("*"), 3, 9);
            layoutTable.Controls.Add(note_Label("**"), 3, 7);
            layoutTable.Controls.Add(note_Label("**"), 3, 10);
            //Help button
            Button helpbutton = new Button();
            helpbutton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            helpbutton.Size = new Size(30, 30);
            helpbutton.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            helpbutton.Text = "MAS INFO!!!";
            helpbutton.Click += conExplain_Click;
            layoutTable.Controls.Add(helpbutton, 1, 10);
        }

        private Label note_Label(string stars)
        {
            return new Label() { Text = stars, Dock = DockStyle.Fill, Size = new Size(43,54), TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Consolas", 15) };
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            manager.CheckForUpdates(UPDATE_URL);
            this.Focus();
        }

        #endregion

        #region Element interaction

        private void elem_Click(object sender, EventArgs e)
        {
            // Close a currently opened info box.
            if (infobox != null) { infobox.Close(); infobox = null; }
            int sendernum = int.Parse(((Button)sender).Name.Substring(0, 3));
            Element elem = ptemanager.PeriodicTable[sendernum];
      
            infobox = new ElementForm(ptemanager, elem);
            infobox.Location = new Point(190, 120);

            infobox.Show(this);


        }

 
        private void elem_Focus(object sender, EventArgs e)
        {
            // Show infos of the currently focused element in status bar.
            int sendernum = int.Parse(((Button)sender).Name.Substring(0, 3));
            Element elem = ptemanager.PeriodicTable[sendernum];
            statInfo.Text = String.Format("{0} ; {1} ; {2}", elem.AtomicNumber, elem.Symbol, elem.LocalizedName);
        }

        private void conExplain_Click(object sender, EventArgs e)
        {
            // Show the dictionary for the currently applied color design.
            ExplanationForm exform = new ExplanationForm(ptemanager.CurrentColor);
            exform.ShowDialog();
        }

        private void quickinfo_Popup(object sender, PopupEventArgs e)
        {
            ((Button)e.AssociatedControl).Focus();
        }

        #endregion

        #region Menu methods

        // Is called if any of the menu items for changing design is clicked.
        private void conViews_Click(object sender, EventArgs e)
        {
            if (!((ToolStripMenuItem)sender).Checked)
            {
                conViewGroups.Checked = false;
                conViewState.Checked = false;
                conViewType.Checked = false;
                int num = 0;
                if (sender == conViewState) num = 1;
                else if (sender == conViewType) num = 2;
                ptemanager.SetColorDesign(num);
                ((ToolStripMenuItem)sender).Checked = true;
                for (int i = 1; i <= elembuttons.Length; i++)
                {
                    string istring = i.ToString("000");
                    Element elem = ptemanager.PeriodicTable[i];
                    elembuttons[i-1].BackColor = ptemanager.GetCurrentColor(elem);
                }
            }
        }

        private void conSearch_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm(ptemanager);
            search.ShowDialog(this);
        }

        private void conPrint_Click(object sender, EventArgs e)
        {
            mainmenu.Focus();
            // A little hack that draws the explanations to the bitmap.
            ExplanationForm exform = new ExplanationForm(ptemanager.CurrentColor);
            exform.Show();
            exform.Hide();
            Bitmap exbox = new Bitmap(exform.tlpElements.Width, exform.tlpElements.Height);
            exform.tlpElements.DrawToBitmap(exbox, new Rectangle(0,0, exbox.Width, exbox.Height));
            // Draw the periodic table.
            Bitmap bmp = new Bitmap(layoutTable.Width, layoutTable.Height);
            layoutTable.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(exbox, 200, 30);
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(35, 490, 30, 30));
            g.Dispose();
            //Bluegrams.BluePrintBmp.PrintBmp(bmp, "ElemenTable - " + Properties.Resources.title_print);
            exbox.Dispose();
            bmp.Dispose();
        }

        private void conExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conAbout_Click(object sender, EventArgs e)
        {
            manager.ShowAboutBox();
        }

        private void menWin10Store_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.microsoft.com/store/apps/9PB2TD7P6DT3");
        }

        #endregion

        private void layoutTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
