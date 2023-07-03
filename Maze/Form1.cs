using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show(".تبریک!شما موفق شدید");
            Close();
        }
        private void MoveToStart()
        {
            Point startingpoint = panel1.Location;
            startingpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingpoint);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
        int flag=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == 0) 
            {
                label41.Enabled = true;
                label41.Visible = true;
                flag = 1;
            }
            else
            {
                label41.Enabled = false;
                label41.Visible = false;
                flag = 0;
            }
        }
    }
}
