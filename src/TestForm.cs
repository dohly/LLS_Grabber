using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace net.grool.util
{
    public partial class TestForm : Form
    {

        public TestForm()
        {
            InitializeComponent();

            BookSelector.SelectedIndex = 0;
        }
        BrowserForm browserForm = null;

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tbUrl.Text.Equals(string.Empty)) return;
            browserForm.Navigate(tbUrl.Text);
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
        /// <summary>
        /// Here I paint a border to picture and  display it
        /// </summary>
        /// <param name="im"></param>
        private void PrepareAndSave(Image im)
        {
            int cropX = 50, cropY = (int)(cropX / 0.707);
            im = cropImage(im, new Rectangle(cropX, cropY, im.Width - cropX * 2, im.Height - cropY * 2));
            var p = tbUrl.Text.Split('/');
            if (!Directory.Exists(p[3]))
            {
                Directory.CreateDirectory(p[3]);
            }
            var f = p[4].Replace("#", "");
            im.Save(Path.Combine(p[3], f + ".png"), ImageFormat.Png);
            //  Graphics g = Graphics.FromImage(im);
            // g.DrawRectangle(Pens.Blue, new Rectangle(0, 0, im.Width - 1, im.Height - 1));
        }
        /// <summary>
        /// Here I populate combo box with PSize objects representing sizes available for thumbnails.
        /// Invisible BrowserForm is created  here as well.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestForm_Load(object sender, EventArgs e)
        {
            browserForm = new BrowserForm();
            browserForm.Show();
            SetUrl();
            this.SpeedRegulator_Scroll(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browserForm.PrintScreen();
            PrepareAndSave(browserForm.Image);
        }

        private Thread t2;
        private void button2_Click(object sender, EventArgs e)
        {
            if (t2 == null)
            {
                var sp = Convert.ToInt32(StartPage.Value);
                progressBar1.Maximum = (int)TotalPages.Value;
                progressBar1.Value = sp;
                t2 = new Thread(() =>
                {
                    for (int i = sp; i < TotalPages.Value + 1; i++)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            PageBox.Text = i.ToString();
                        });
                        browserForm.Navigate(tbUrl.Text);
                        var timeout = (int)SpeedRegulator.Invoke(new Func<int>(() => SpeedRegulator.Value));
                        Thread.Sleep(timeout);
                        this.Invoke((MethodInvoker)delegate
                        {
                            browserForm.PrintScreen();
                            PrepareAndSave(browserForm.Image);
                            progressBar1.Value = i;
                        });

                    }
                });
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
                button2.Text = "stop auto";
            }
            else
            {
                t2.Abort();
                button2.Text = "Auto";
                t2 = null;
            }
        }

        private void HostBox_TextChanged(object sender, EventArgs e)
        {
            SetUrl();
        }

        private void SetUrl()
        {
            this.tbUrl.Text = string.Format("http://{0}/{1}/#{2}/z", this.HostBox.Text, this.BookSelector.SelectedItem,
                this.PageBox.Text);
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            int p = -1;
            if (int.TryParse(this.PageBox.Text, out p))
            {
                p--;
                PageBox.Text = p.ToString();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int p = -1;
            if (int.TryParse(this.PageBox.Text, out p))
            {
                p++;
                PageBox.Text = p.ToString();
            }
        }

        private void PageBox_TextChanged(object sender, EventArgs e)
        {
            SetUrl();
        }

        private void BookSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUrl();
        }

        private void StartPage_ValueChanged(object sender, EventArgs e)
        {
            this.PageBox.Text = StartPage.Value.ToString();
        }

        private void TotalPages_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Maximum = (int)TotalPages.Value;
        }

        private void SpeedRegulator_Scroll(object sender, EventArgs e)
        {
            this.SpeedLabel.Text = string.Format("Speed: {0} ms per page", this.SpeedRegulator.Value);
        }
    }
}