using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace net.grool.util
{
	public partial class BrowserForm : Form
	{
		public BrowserForm()
		{
			InitializeComponent();
		}

		public Image Image { get; set; }
		/// <summary>
		/// This method calls starts download of the page .
		/// </summary>
		/// <param name="url"></param>
		public void Navigate(string url)
		{

			try
			{
				this.webBrowser1.Url = new Uri(url);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);

			}



		}
		

	    public void PrintScreen()
	    {

            try
            {
                Bitmap docImage = new Bitmap(webBrowser1.Width, webBrowser1.Height);
                webBrowser1.DrawToBitmap(docImage, new Rectangle(webBrowser1.Location.X, webBrowser1.Location.Y, webBrowser1.Width, webBrowser1.Height));
                this.Image = docImage;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}