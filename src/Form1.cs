using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Printing;

namespace DEMO
{
    public partial class Form1 : Form
    {
        private MyButton button2;
        PrintDocument pd = null;
        StreamReader STreamToPrint = null;
        public Form1()
        {
            InitializeComponent();
            //button2 = new MyButton();
            //button2.Location = new System.Drawing.Point(196, 164);
            //button2.Name = "button2";
            //button2.Size = new System.Drawing.Size(75, 23);
            //button2.TabIndex = 0;
            //button2.Text = "button2";
            //button2.UseVisualStyleBackColor = true;
            ////button2.Click += new System.EventHandler(this.button1_Click);
            //this.Controls.Add(this.button2);
       
         
        }
       

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(System.IntPtr hWnd, string text, string caption, uint type);
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text.Equals(string.Empty)) return;
            webBrowser1.Url = new Uri(tbUrl.Text);
          drawing=new Bitmap(600,800);
          webBrowser1.DrawToBitmap(drawing,new Rectangle(webBrowser1.Location.X,webBrowser1.Location.Y,webBrowser1.Width,webBrowser1.Height));
          Graphics g = pBrowser.CreateGraphics();
          
          int width = drawing.Width;
          int height = drawing.Height;
          RectangleF destinationRect = new RectangleF(
              10,
              20,
              0.3f * width,
              0.3f * height);

          RectangleF sourceRect = new RectangleF(0, 0,  width, height);
         g.DrawImage(
              drawing,
              destinationRect,
              sourceRect,
              GraphicsUnit.Pixel);


            //MessageBox(System.IntPtr.Zero, "hello", "caption text", 0);
        }
        Bitmap drawing = null;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}