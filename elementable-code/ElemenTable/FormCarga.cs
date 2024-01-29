using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElemenTable
{
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
        }
        Timer myTimer = new Timer();
        private void FormCarga_Load(object sender, EventArgs e)
        {
            
            // Crear un nuevo Timer
      
     
            myTimer.Interval = 3000; // Intervalo de 1 segundo (1000 ms)
            myTimer.Start();
            myTimer.Tick += new EventHandler(Timer_Tick); // Suscribir el método que manejará el evento Tick
           

        }

        private void Timer_Tick(object sender, EventArgs e)
        {


            this.Hide();
            MainForm obj = new MainForm();
            obj.Show();
            
            myTimer.Stop();
        }

    }
}
