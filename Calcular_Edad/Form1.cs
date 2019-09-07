using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lbledad.Text = "";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            DateTime fechanac = fechanacimiento.Value;
            int años = System.DateTime.Now.Year - fechanac.Year;
            if (System.DateTime.Now.Subtract(fechanac.AddYears(años)).TotalDays < 0)
                lbledad.Text = Convert.ToString(años - 1);
            else
                lbledad.Text = Convert.ToString(años);
        }
    }
}
