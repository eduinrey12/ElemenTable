using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using Bluegrams.Periodica.Data;
using System.Reflection;
using System.Linq;

namespace ElemenTable
{
    public partial class ElementForm : Form
    {
        private Element elem;
        private TableManager ptemanager;
        private ResourceManager res;

        public ElementForm(TableManager ptemanager, Element elem)
        {
            this.ptemanager = ptemanager;
            this.elem = elem;
            InitializeComponent();
            res = new ResourceManager("ElemenTable.Properties.Resources", typeof(MainForm).Assembly);
            // Set items above property table.
            lblElement.Text = String.Format("{0}\n{1}", elem.AtomicNumber, elem.Symbol);
            lblNumber.Text = String.Format("[{0}]", elem.AtomicNumber);
            lblSymbol.Text = elem.Symbol;
            lblName.Text = elem.LocalizedName;
            lblGroup.Text = String.Format("{0} - G {1} | P {2}",
                res.GetString(elem.Category.ToString()),
                elem.Group,
                elem.Period);
            // Load all other properties into table.
            loadPropertiesTable();
            // Set colors.
            if (elem.StandardState == StateOfMatter.Solid)
            { lblState.Text = "s"; lblState.BackColor = Color.Gray; }
            else if (elem.StandardState == StateOfMatter.Liquid)
            { lblState.Text = "l"; lblState.BackColor = Color.DodgerBlue; }
            else if (elem.StandardState == StateOfMatter.Gas)
            { lblState.Text = "g"; lblState.BackColor = Color.YellowGreen; }
            lblGroup.BackColor = ptemanager.GetCurrentColor(elem);
            panBox.BackColor = ptemanager.GetCurrentColor(elem);
            if (elem.Radioactive) panRadioactive.Visible = true;

            mostrarCapas(elem);
        }

        private void mostrarCapas(Element elem)
        {
            CapasElectronicas formSecundario = new CapasElectronicas(elem.AtomicNumber);
            formSecundario.TopLevel = false; // Indica que no es un formulario de nivel superior
            formSecundario.FormBorderStyle = FormBorderStyle.None; // Quita los bordes del formulario

            pnlAtomo.Controls.Clear(); // Limpia el contenido del panel
            pnlAtomo.Controls.Add(formSecundario); // Agrega el formulario al panel
            formSecundario.Dock = DockStyle.Fill; // Ajusta el formulario al tamaño del panel

            formSecundario.Show(); // Muestra el formulario secundario en el panel
        }

        private void ElementForm_Load(object sender, EventArgs e)
        {
            Owner.Move += owner_Move;
            owner_Move(null, null);
        }

        private void loadPropertiesTable()
        {
            addTableInfo(0, nameof(elem.AtomicMass));
            addTableInfo(1, nameof(elem.StandardState));
            addTableInfo(2, nameof(elem.OxidationStates));
            addTableInfo(3, nameof(elem.Configuration));
            addTableInfo(4, nameof(elem.ShellConfiguration));
            addTableInfo(5, nameof(elem.Electronegativity));
            addTableInfo(6, nameof(elem.MeltingPoint));
            addTableInfo(7, nameof(elem.BoilingPoint));
            addTableInfo(8, nameof(elem.Density));
            addTableInfo(9, nameof(elem.HeatCapacity));
            addTableInfo(10, nameof(elem.HeatOfFusion));
            addTableInfo(11, nameof(elem.HeatOfVaporization));
            addTableInfo(12, nameof(elem.MolarVolume));
            addTableInfo(13, nameof(elem.ThermalConductivity));
            addTableInfo(14, nameof(elem.AtomicRadius));
            addTableInfo(15, nameof(elem.CovalentRadius));
            addTableInfo(16, nameof(elem.VanDerWaalsRadius));
            addTableInfo(17, nameof(elem.IonizationEnergy));
            addTableInfo(18, nameof(elem.ElectronAffinity));
            addTableInfo(19, nameof(elem.AbundanceCrust));
            addTableInfo(20, nameof(elem.AbundanceUniverse));
            addTableInfo(21, nameof(elem.Discovery));
            addTableInfo(22, nameof(elem.DiscoveredBy));
        }

        private void addTableInfo(int row, string name)
        {
            var prop = typeof(Element).GetProperty(name);
            var value = prop.GetValue(elem);
            if (value != null)
            {
                string text = "";
                // Pay special attention to two properties that are int arrays.
                if (prop.PropertyType == typeof(int[]))
                    text += String.Join(",", (int[])value);
                else text += value?.ToString();
                // Read the unit string for the given property if available.
                UnitAttribute unit = (UnitAttribute)prop.GetCustomAttributes().Where(v => v is UnitAttribute).FirstOrDefault();
                if (unit != null) text += " " + unit.UnitString;
                tableInfo.Controls.Add(
                    new Label() { Dock = DockStyle.Fill, Size = new Size(130, 21), TextAlign = ContentAlignment.MiddleCenter, Text = text },
                    1, row);
            }
        }

        private void owner_Move(object sender, EventArgs e)
        {
            try
            {
                if (Owner != null)
                {
                    int xpoint = Owner.Location.X + (Owner.Width - this.Width) / 2;
                    int ypoint = Owner.Location.Y + (Owner.Height - this.Height) / 2;
                    this.Location = new Point(xpoint, ypoint);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlAtomo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
