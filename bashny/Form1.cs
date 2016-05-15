using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
            bool drag;


       

        private void lt_MouseMove(object sender, MouseEventArgs e)
        {
            int offsetX = 0;
            int offsetY = 0;
            
            if (drag)
            {
                int x = Cursor.Position.X - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2) - offsetX;
                int y = Cursor.Position.Y - (this.Top + (this.Size.Height - this.ClientSize.Height - 4)) - offsetY;
                if (x > 0 && x < this.ClientSize.Width - lt.Width)
                    lt.Left = x;
                else
                    lt.Left = x > 0 ? x = this.ClientSize.Width - lt.Width : 0;
                if (y > 0 && y < this.ClientSize.Height - lt.Height)
                    lt.Top = y;
                else
                    lt.Top = y > 0 ? y = this.ClientSize.Height - lt.Height : 0;
            }
        }

      

        private void lt_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }


        private void lt_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;

        }



        bool joi;

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            int offsetX = 0;
            int offsetY = 0;

            if (joi)
            {
                int x = Cursor.Position.X - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2) - offsetX;
                int y = Cursor.Position.Y - (this.Top + (this.Size.Height - this.ClientSize.Height - 4)) - offsetY;
                if (x > 0 && x < this.ClientSize.Width - pictureBox8.Width)
                    pictureBox8.Left = x;
                else
                    pictureBox8.Left = x > 0 ? x = this.ClientSize.Width - pictureBox8.Width : 0;
                if (y > 0 && y < this.ClientSize.Height - pictureBox8.Height)
                    pictureBox8.Top = y;
                else
                    pictureBox8.Top = y > 0 ? y = this.ClientSize.Height - pictureBox8.Height : 0;
            }

        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
             joi = true;
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
           joi = false;
        }









    }
}
