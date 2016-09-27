namespace net.grool.util
{
	partial class TestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BookSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PageBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalPages = new System.Windows.Forms.NumericUpDown();
            this.PreviousPageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.StartPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.SpeedRegulator = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedRegulator)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Screen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(56, 104);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(465, 20);
            this.tbUrl.TabIndex = 10;
            this.tbUrl.Text = "http://www.akteon-elib.ru/LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Kniga-2" +
    "/#1/z";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(3, 107);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 11;
            this.lblUrl.Text = "Url";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(541, 99);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 28);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "Go to URL";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BookSelector
            // 
            this.BookSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BookSelector.FormattingEnabled = true;
            this.BookSelector.Items.AddRange(new object[] {
            "LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Kniga-1",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Kniga-2",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Kniga-3",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Kniga-4",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Bibleiskaya-istoriya-Soprovoditel-nyi-tom",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-1",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-2",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-3",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-4",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-5",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-6",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-7",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-8",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-9",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Kniga-10",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Vsemirnaya-istoriya-Soprovoditel-nyi-tom",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-1",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-2",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-3",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-4",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-5",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-6",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-7",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-8",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-9",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-10",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-11",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-12",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-13",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-14",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-15",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-16",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-17",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-18",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-19",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-20",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-21",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-22",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Kniga-23",
            "LITsIeVOI-LIeTOPISNYI-SVOD-Russkaya-letopisnaya-istoriya-Soprovoditel-nyi-tom"});
            this.BookSelector.Location = new System.Drawing.Point(56, 32);
            this.BookSelector.Name = "BookSelector";
            this.BookSelector.Size = new System.Drawing.Size(367, 21);
            this.BookSelector.TabIndex = 16;
            this.BookSelector.SelectedIndexChanged += new System.EventHandler(this.BookSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Host";
            // 
            // HostBox
            // 
            this.HostBox.Location = new System.Drawing.Point(56, 2);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(223, 20);
            this.HostBox.TabIndex = 17;
            this.HostBox.Text = "www.akteon-elib.ru";
            this.HostBox.TextChanged += new System.EventHandler(this.HostBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Page";
            // 
            // PageBox
            // 
            this.PageBox.AutoCompleteCustomSource.AddRange(new string[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII"});
            this.PageBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PageBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PageBox.Location = new System.Drawing.Point(56, 67);
            this.PageBox.Name = "PageBox";
            this.PageBox.Size = new System.Drawing.Size(100, 20);
            this.PageBox.TabIndex = 18;
            this.PageBox.Text = "I";
            this.PageBox.TextChanged += new System.EventHandler(this.PageBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Pages";
            // 
            // TotalPages
            // 
            this.TotalPages.Location = new System.Drawing.Point(377, 65);
            this.TotalPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TotalPages.Name = "TotalPages";
            this.TotalPages.Size = new System.Drawing.Size(46, 20);
            this.TotalPages.TabIndex = 19;
            this.TotalPages.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            this.TotalPages.ValueChanged += new System.EventHandler(this.TotalPages_ValueChanged);
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Location = new System.Drawing.Point(462, 62);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Size = new System.Drawing.Size(29, 23);
            this.PreviousPageBtn.TabIndex = 20;
            this.PreviousPageBtn.Text = "<<";
            this.PreviousPageBtn.UseVisualStyleBackColor = true;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Location = new System.Drawing.Point(497, 62);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(28, 23);
            this.NextPageBtn.TabIndex = 21;
            this.NextPageBtn.Text = ">>";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // StartPage
            // 
            this.StartPage.Location = new System.Drawing.Point(232, 68);
            this.StartPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(58, 20);
            this.StartPage.TabIndex = 23;
            this.StartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartPage.ValueChanged += new System.EventHandler(this.StartPage_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Start From";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 188);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(610, 12);
            this.progressBar1.TabIndex = 24;
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(12, 146);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.SpeedLabel.TabIndex = 11;
            this.SpeedLabel.Text = "Speed";
            // 
            // SpeedRegulator
            // 
            this.SpeedRegulator.LargeChange = 500;
            this.SpeedRegulator.Location = new System.Drawing.Point(215, 137);
            this.SpeedRegulator.Maximum = 10000;
            this.SpeedRegulator.Minimum = 1500;
            this.SpeedRegulator.Name = "SpeedRegulator";
            this.SpeedRegulator.Size = new System.Drawing.Size(111, 45);
            this.SpeedRegulator.SmallChange = 100;
            this.SpeedRegulator.TabIndex = 25;
            this.SpeedRegulator.Value = 1500;
            this.SpeedRegulator.Scroll += new System.EventHandler(this.SpeedRegulator_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Low";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fast";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 212);
            this.Controls.Add(this.SpeedRegulator);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.StartPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NextPageBtn);
            this.Controls.Add(this.PreviousPageBtn);
            this.Controls.Add(this.TotalPages);
            this.Controls.Add(this.PageBox);
            this.Controls.Add(this.HostBox);
            this.Controls.Add(this.BookSelector);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestForm";
            this.Text = "LLS Grabber";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedRegulator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox BookSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PageBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TotalPages;
        private System.Windows.Forms.Button PreviousPageBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.NumericUpDown StartPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.TrackBar SpeedRegulator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}