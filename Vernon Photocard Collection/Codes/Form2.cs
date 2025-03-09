using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vernon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void InstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on a menu item to show relevant picture; click again to hide the picture.");
        }
        
        private void Menu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            GetPBFromMenuItem(tsmi);
        }

        private void GetPBFromMenuItem(ToolStripMenuItem toolStripMenuItem)
        {
            switch (toolStripMenuItem.Name)
            {
                case "FollowTour":
                    ShowPic(pictureBox1);
                    break;
                case "BlackEye":
                    ShowPic(pictureBox2);
                    break;
                case "DiconDFesta":
                    ShowPic(pictureBox3);
                    break;
            }   
        }

        private void ShowPic(PictureBox pictureBox)
        {
            if (!pictureBox.Visible)
            {
                pictureBox.Show();
            }
            else
            {
                pictureBox.Hide();
            }
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cover Photo: SEVENTEEN 7TH MINI ALBUM '헹가래[Heng:garæ]' Official Photo ©Pledis Entertainment\nCard Photo: instagram.com/oncevernon");
        }

        private void ReturnToCoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
} 