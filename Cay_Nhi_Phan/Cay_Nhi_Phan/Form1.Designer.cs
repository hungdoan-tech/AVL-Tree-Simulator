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
			this.Input_TextBox = new System.Windows.Forms.TextBox();
			this.Del_Tree_Button = new System.Windows.Forms.Button();
			this.ComboBox_Speed = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.N_Random_Label = new System.Windows.Forms.Label();
			this.Del_Node_Button = new System.Windows.Forms.Button();
			this.Random_Button = new System.Windows.Forms.Button();
			this.Find_Button = new System.Windows.Forms.Button();
			this.Random_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Random_NumericUpDown)).BeginInit();
			this.groupBox2.SuspendLayout();
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
			// Input_TextBox
			// 
			this.Input_TextBox.AcceptsReturn = true;
			this.Input_TextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.Input_TextBox.Location = new System.Drawing.Point(6, 45);
			this.Input_TextBox.Name = "Input_TextBox";
			this.Input_TextBox.Size = new System.Drawing.Size(118, 20);
			this.Input_TextBox.TabIndex = 1;
			this.Input_TextBox.Text = "Input + Enter to Insert";
			this.Input_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
			// 
			// Del_Tree_Button
			// 
			this.Del_Tree_Button.Location = new System.Drawing.Point(143, 93);
			this.Del_Tree_Button.Name = "Del_Tree_Button";
			this.Del_Tree_Button.Size = new System.Drawing.Size(75, 23);
			this.Del_Tree_Button.TabIndex = 3;
			this.Del_Tree_Button.Text = "Delete Tree";
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
			this.ComboBox_Speed.Location = new System.Drawing.Point(37, 80);
			this.ComboBox_Speed.Name = "ComboBox_Speed";
			this.ComboBox_Speed.Size = new System.Drawing.Size(66, 21);
			this.ComboBox_Speed.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.ComboBox_Speed);
			this.groupBox1.Controls.Add(this.N_Random_Label);
			this.groupBox1.Controls.Add(this.Del_Node_Button);
			this.groupBox1.Controls.Add(this.Random_Button);
			this.groupBox1.Controls.Add(this.Find_Button);
			this.groupBox1.Controls.Add(this.Del_Tree_Button);
			this.groupBox1.Controls.Add(this.Random_NumericUpDown);
			this.groupBox1.Controls.Add(this.Input_TextBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 513);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 118);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic";
			// 
			// N_Random_Label
			// 
			this.N_Random_Label.AutoSize = true;
			this.N_Random_Label.Location = new System.Drawing.Point(3, 18);
			this.N_Random_Label.Name = "N_Random_Label";
			this.N_Random_Label.Size = new System.Drawing.Size(15, 13);
			this.N_Random_Label.TabIndex = 8;
			this.N_Random_Label.Text = "N";
			// 
			// Del_Node_Button
			// 
			this.Del_Node_Button.Location = new System.Drawing.Point(143, 64);
			this.Del_Node_Button.Name = "Del_Node_Button";
			this.Del_Node_Button.Size = new System.Drawing.Size(75, 23);
			this.Del_Node_Button.TabIndex = 7;
			this.Del_Node_Button.Text = "Delete Node";
			this.Del_Node_Button.UseVisualStyleBackColor = true;
			this.Del_Node_Button.Click += new System.EventHandler(this.Del_Node_Button_Click);
			// 
			// Random_Button
			// 
			this.Random_Button.Location = new System.Drawing.Point(143, 8);
			this.Random_Button.Name = "Random_Button";
			this.Random_Button.Size = new System.Drawing.Size(75, 23);
			this.Random_Button.TabIndex = 6;
			this.Random_Button.Text = "Random";
			this.Random_Button.UseVisualStyleBackColor = true;
			this.Random_Button.Click += new System.EventHandler(this.Random_Button_Click);
			// 
			// Find_Button
			// 
			this.Find_Button.Location = new System.Drawing.Point(143, 35);
			this.Find_Button.Name = "Find_Button";
			this.Find_Button.Size = new System.Drawing.Size(75, 23);
			this.Find_Button.TabIndex = 5;
			this.Find_Button.Text = "Find";
			this.Find_Button.UseVisualStyleBackColor = true;
			this.Find_Button.Click += new System.EventHandler(this.Find_Button_Click);
			// 
			// Random_NumericUpDown
			// 
			this.Random_NumericUpDown.Location = new System.Drawing.Point(24, 16);
			this.Random_NumericUpDown.Name = "Random_NumericUpDown";
			this.Random_NumericUpDown.Size = new System.Drawing.Size(79, 20);
			this.Random_NumericUpDown.TabIndex = 4;
			this.Random_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Random_NumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Location = new System.Drawing.Point(248, 513);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(88, 119);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Order ";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.textBox4);
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Controls.Add(this.textBox2);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.richTextBox1);
			this.groupBox4.Location = new System.Drawing.Point(342, 511);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(556, 119);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Info";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 78);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "LRN";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 48);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "LNR";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "NLR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(170, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(380, 105);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Leaf Node";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Avange Node";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "The Height";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(103, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(61, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(103, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(61, 20);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(103, 63);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(61, 20);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(103, 89);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(61, 20);
			this.textBox4.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Total Node";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(-3, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Speed";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1050, 642);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pb_Main);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Random_NumericUpDown)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pb_Main;
		private System.Windows.Forms.TextBox Input_TextBox;
		private System.Windows.Forms.Button Del_Tree_Button;
		private System.Windows.Forms.ComboBox ComboBox_Speed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button Find_Button;
		private System.Windows.Forms.NumericUpDown Random_NumericUpDown;
		private System.Windows.Forms.Button Del_Node_Button;
		private System.Windows.Forms.Button Random_Button;
		private System.Windows.Forms.Label N_Random_Label;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

