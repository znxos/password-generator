using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView1
        {

            get { return dataGridView1;}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Point lastLocation;
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // this is to prevent this error //
            /*
             * System.ObjectDisposedException: 'Cannot access a disposed object.
             * Object name: 'Form2'.'
             */
            // The above error occurs when you try to open the form after closing it.

            e.Cancel = true; // Cancel the close event

            lastLocation = this.Location; // saves the last location of the form - may come back to it.

            this.Hide(); //hide the form 
        }
    }
}
