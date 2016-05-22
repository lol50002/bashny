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
        bool joi;
        
        List<int> stolbik1 = new List<int>();
        List<int> stolbik2 = new List<int>();
        List<int> stolbik3= new List<int>();



        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            int offsetX = 0;
            int offsetY = 0;
            PictureBox pb = (PictureBox)sender;
            label1.Text = e.X.ToString();
            label2.Text = Cursor.Position.X.ToString();
            if (joi)
            {
                int x = Cursor.Position.X - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2) - offsetX;
                int y = Cursor.Position.Y - (this.Top + (this.Size.Height - this.ClientSize.Height - 4)) - offsetY;
                if (x > 0 && x < this.ClientSize.Width - pb.Width)
                    pb.Left = x;
                else
                    pb.Left = x > 0 ? x = this.ClientSize.Width - pb.Width : 0;
                if (y > 0 && y < this.ClientSize.Height - pb.Height)
                    pb.Top = y;
                else
                    pb.Top = y > 0 ? y = this.ClientSize.Height - pb.Height : 0;
            }

        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
             joi = true;
             switch ((Convert.ToInt32(label2.Text) - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2)/(this.ClientSize.Width/3))
             {
                case 0:
                     stolbik1.RemoveAt(stolbik1.Count-1);
                     break;
                case 1:
                     stolbik2.RemoveAt(stolbik2.Count - 1);
                     break;
                case 2:
                     stolbik3.RemoveAt(stolbik3.Count - 1);
                     break;
             }
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
           joi = false;
           PictureBox pb = (PictureBox)sender;
           switch ((Convert.ToInt32(label2.Text) - (this.Left + (this.Size.Width - this.ClientSize.Width) / 2)) / (this.ClientSize.Width / 3))
           {
               case 0:
                   stolbik1.Add(Convert.ToInt32(pb.Tag.ToString()));
                   break;
               case 1:
                   stolbik2.Add(Convert.ToInt32(pb.Tag.ToString()));
                   break;
               case 2:
                   stolbik3.Add(Convert.ToInt32(pb.Tag.ToString()));
                   break;

           }

        } 


        private void Form1_Load(object sender, EventArgs e)
        {       
            stolbik1.Add(3);
            stolbik1.Add(2); 
            stolbik1.Add(1);
            stolbik1.Add(0);
        }









    }
}
