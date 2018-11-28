namespace Cay_Nhi_Phan
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
			this.pb_Main = new System.Windows.Forms.PictureBox();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.Del_Tree_Button = new System.Windows.Forms.Button();
			this.ComboBox_Speed = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pb_Main
			// 
			this.pb_Main.BackColor = System.Drawing.Color.White;
			this.pb_Main.Location = new System.Drawing.Point(12, 12);
			this.pb_Main.Name = "pb_Main";
			this.pb_Main.Size = new System.Drawing.Size(1024, 495);
			this.pb_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Main.TabIndex = 1;
			this.pb_Main.TabStop = false;
			this.pb_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_Main_MouseMove);
			// 
			// txtInput
			// 
			this.txtInput.AcceptsReturn = true;
			this.txtInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtInput.Location = new System.Drawing.Point(6, 70);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(118, 20);
			this.txtInput.TabIndex = 2;
			this.txtInput.Text = "Nhap so vao + Enter";
			this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			// 
			// Del_Tree_Button
			// 
			this.Del_Tree_Button.Location = new System.Drawing.Point(181, 19);
			this.Del_Tree_Button.Name = "Del_Tree_Button";
			this.Del_Tree_Button.Size = new System.Drawing.Size(75, 23);
			this.Del_Tree_Button.TabIndex = 3;
			this.Del_Tree_Button.Text = "Del_Tree";
			this.Del_Tree_Button.UseVisualStyleBackColor = true;
			this.Del_Tree_Button.Click += new System.EventHandler(this.Del_Tree_Button_Click);
			// 
			// ComboBox_Speed
			// 
			this.ComboBox_Speed.FormattingEnabled = true;
			this.ComboBox_Speed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.ComboBox_Speed.Location = new System.Drawing.Point(141, 70);
			this.ComboBox_Speed.Name = "ComboBox_Speed";
			this.ComboBox_Speed.Size = new System.Drawing.Size(121, 21);
			this.ComboBox_Speed.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Del_Tree_Button);
			this.groupBox1.Controls.Add(this.ComboBox_Speed);
			this.groupBox1.Controls.Add(this.txtInput);
			this.groupBox1.Location = new System.Drawing.Point(12, 532);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 99);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(319, 531);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(575, 531);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(836, 530);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 100);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "groupBox4";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1060, 644);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pb_Main);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pb_Main;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button Del_Tree_Button;
		private System.Windows.Forms.ComboBox ComboBox_Speed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

