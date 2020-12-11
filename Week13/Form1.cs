using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13
{
    public partial class url_interface : System.Windows.Forms.Form
    {
        public url_interface()
        {
            InitializeComponent();

        }

        private void url_interface_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void url_data_Click(object sender, EventArgs e)
        {

        }

        private void url_interface_Load(object sender, EventArgs e)
        {

        }

        private void url_proses_Click(object sender, EventArgs e)
        {
            if (labelUbah.Text == "[EMPTY]")
            {
                labelUbah.Text = Inputdata.Text;
            }
        
        }

        private void ulr_isi_Click(object sender, EventArgs e)
        {
           
        }

        private void Inputdata_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
