using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vernon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide(); // hide the parent form

            Form2 form2 = new Form2();
            form2.Show(); // show the child form [note: By using .Show(), you can go back to the parent form, while .ShowDialog() does the opposite.]  
        }
    }
}
