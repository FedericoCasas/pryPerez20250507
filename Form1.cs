using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryPerez20250507
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbSuperheroe.Items.Add("Batman");
            cmbSuperheroe.Items.Add("Superman");
            cmbSuperheroe.Items.Add("Wonder Woman");



            
        }

        private void cmbSuperheroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSuperheroe.SelectedItem.ToString() == "Batman") {

                lblPersonaje.Text = "Batman";

            }
            else if(cmbSuperheroe.SelectedItem.ToString() == "Superman") {
                lblPersonaje.Text = "superman";

            } else {
                lblPersonaje.Text = "women";

            }

        }
    }
}
