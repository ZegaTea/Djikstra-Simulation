namespace Djikstra
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.cbEnd = new System.Windows.Forms.ComboBox();
			this.cbStart = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLine = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDirection = new System.Windows.Forms.TextBox();
			this.txtCost = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaxLine = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Location = new System.Drawing.Point(3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(700, 525);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtMaxLine);
			this.panel1.Controls.Add(this.txtCost);
			this.panel1.Controls.Add(this.txtDirection);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.cbEnd);
			this.panel1.Controls.Add(this.cbStart);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtLine);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(709, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(235, 525);
			this.panel1.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(19, 208);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(135, 23);
			this.button3.TabIndex = 19;
			this.button3.Text = "&Tìm đường đi ngắn nhất";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cbEnd
			// 
			this.cbEnd.FormattingEnabled = true;
			this.cbEnd.Location = new System.Drawing.Point(122, 165);
			this.cbEnd.Name = "cbEnd";
			this.cbEnd.Size = new System.Drawing.Size(97, 21);
			this.cbEnd.TabIndex = 18;
			this.cbEnd.SelectedIndexChanged += new System.EventHandler(this.cbEnd_SelectedIndexChanged);
			// 
			// cbStart
			// 
			this.cbStart.FormattingEnabled = true;
			this.cbStart.Location = new System.Drawing.Point(122, 126);
			this.cbStart.Name = "cbStart";
			this.cbStart.Size = new System.Drawing.Size(97, 21);
			this.cbStart.TabIndex = 17;
			this.cbStart.SelectedIndexChanged += new System.EventHandler(this.cbStart_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Chọn điểm kết thúc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Chọn điểm bắt đầu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Nhập số cạnh";
			// 
			// txtLine
			// 
			this.txtLine.Location = new System.Drawing.Point(96, 83);
			this.txtLine.Name = "txtLine";
			this.txtLine.Size = new System.Drawing.Size(37, 20);
			this.txtLine.TabIndex = 13;
			this.txtLine.Text = "15";
			this.txtLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(151, 83);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(68, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "&Gen";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(203, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "&Reset";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(19, 315);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(200, 192);
			this.richTextBox1.TabIndex = 21;
			this.richTextBox1.Text = "";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(160, 208);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(59, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "&Restore";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "Độ dài quãng đường";
			// 
			// txtDirection
			// 
			this.txtDirection.Location = new System.Drawing.Point(19, 280);
			this.txtDirection.Name = "txtDirection";
			this.txtDirection.ReadOnly = true;
			this.txtDirection.Size = new System.Drawing.Size(200, 20);
			this.txtDirection.TabIndex = 25;
			this.txtDirection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCost
			// 
			this.txtCost.Location = new System.Drawing.Point(122, 248);
			this.txtCost.Name = "txtCost";
			this.txtCost.ReadOnly = true;
			this.txtCost.Size = new System.Drawing.Size(97, 20);
			this.txtCost.TabIndex = 26;
			this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Số đường tối đa tạo được";
			// 
			// txtMaxLine
			// 
			this.txtMaxLine.Location = new System.Drawing.Point(151, 51);
			this.txtMaxLine.Name = "txtMaxLine";
			this.txtMaxLine.ReadOnly = true;
			this.txtMaxLine.Size = new System.Drawing.Size(68, 20);
			this.txtMaxLine.TabIndex = 27;
			this.txtMaxLine.Text = "0";
			this.txtMaxLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(950, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Djikstra";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cbEnd;
		private System.Windows.Forms.ComboBox cbStart;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLine;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox txtDirection;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox txtCost;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaxLine;
	}
}

