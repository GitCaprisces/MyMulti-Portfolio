using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EPV_1912527
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    private void TxtCalificacion_Click(object sender, EventArgs e)
        {
            TxtCalificacion.Clear();
            
        }
        private void TxtCalificacion_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (TxtCalificacion.Text >= 70)
            {
                lblResultado.Text = "Ha aprobado";
            }
        }
    }
}
