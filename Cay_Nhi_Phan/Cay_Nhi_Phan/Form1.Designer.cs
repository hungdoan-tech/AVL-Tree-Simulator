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
			this.Main_PictureBox = new System.Windows.Forms.PictureBox();
			this.Input_TextBox = new System.Windows.Forms.TextBox();
			this.Del_Tree_Button = new System.Windows.Forms.Button();
			this.Speed_ComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Speed_Label = new System.Windows.Forms.Label();
			this.N_Random_Label = new System.Windows.Forms.Label();
			this.Del_Node_Button = new System.Windows.Forms.Button();
			this.Random_Button = new System.Windows.Forms.Button();
			this.Find_Button = new System.Windows.Forms.Button();
			this.Random_NumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.NLR_Button = new System.Windows.Forms.Button();
			this.LNR_Button = new System.Windows.Forms.Button();
			this.LRN_Button = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.Total_Node_Label = new System.Windows.Forms.Label();
			this.The_Height_Tree_TextBox = new System.Windows.Forms.TextBox();
			this.Total_Intermediate_Node_TextBox = new System.Windows.Forms.TextBox();
			this.Total_Leaf_Node_TextBox = new System.Windows.Forms.TextBox();
			this.Total_Node_TextBox = new System.Windows.Forms.TextBox();
			this.The_Height_Tree_Label = new System.Windows.Forms.Label();
			this.Intermediate_Node_Label = new System.Windows.Forms.Label();
			this.Leaf_Node_Label = new System.Windows.Forms.Label();
			this.Way_RichTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Random_NumericUpDown)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// Main_PictureBox
			// 
			this.Main_PictureBox.BackColor = System.Drawing.Color.White;
			this.Main_PictureBox.Location = new System.Drawing.Point(6, 6);
			this.Main_PictureBox.Name = "Main_PictureBox";
			this.Main_PictureBox.Size = new System.Drawing.Size(1092, 515);
			this.Main_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Main_PictureBox.TabIndex = 1;
			this.Main_PictureBox.TabStop = false;
			this.Main_PictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseClick);
			this.Main_PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_PictureBox_MouseMove);
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
			this.Input_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_TextBox_KeyDown);
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
			// Speed_ComboBox
			// 
			this.Speed_ComboBox.FormattingEnabled = true;
			this.Speed_ComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.Speed_ComboBox.Location = new System.Drawing.Point(37, 80);
			this.Speed_ComboBox.Name = "Speed_ComboBox";
			this.Speed_ComboBox.Size = new System.Drawing.Size(66, 21);
			this.Speed_ComboBox.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Speed_Label);
			this.groupBox1.Controls.Add(this.Speed_ComboBox);
			this.groupBox1.Controls.Add(this.N_Random_Label);
			this.groupBox1.Controls.Add(this.Del_Node_Button);
			this.groupBox1.Controls.Add(this.Random_Button);
			this.groupBox1.Controls.Add(this.Find_Button);
			this.groupBox1.Controls.Add(this.Del_Tree_Button);
			this.groupBox1.Controls.Add(this.Random_NumericUpDown);
			this.groupBox1.Controls.Add(this.Input_TextBox);
			this.groupBox1.Location = new System.Drawing.Point(12, 532);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 118);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic";
			// 
			// Speed_Label
			// 
			this.Speed_Label.AutoSize = true;
			this.Speed_Label.Location = new System.Drawing.Point(-3, 83);
			this.Speed_Label.Name = "Speed_Label";
			this.Speed_Label.Size = new System.Drawing.Size(38, 13);
			this.Speed_Label.TabIndex = 9;
			this.Speed_Label.Text = "Speed";
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
			this.groupBox2.Controls.Add(this.NLR_Button);
			this.groupBox2.Controls.Add(this.LNR_Button);
			this.groupBox2.Controls.Add(this.LRN_Button);
			this.groupBox2.Location = new System.Drawing.Point(248, 532);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(88, 119);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Order ";
			// 
			// NLR_Button
			// 
			this.NLR_Button.Location = new System.Drawing.Point(6, 19);
			this.NLR_Button.Name = "NLR_Button";
			this.NLR_Button.Size = new System.Drawing.Size(75, 23);
			this.NLR_Button.TabIndex = 0;
			this.NLR_Button.Text = "NLR";
			this.NLR_Button.UseVisualStyleBackColor = true;
			this.NLR_Button.Click += new System.EventHandler(this.NLR_Button_Click);
			// 
			// LNR_Button
			// 
			this.LNR_Button.Location = new System.Drawing.Point(6, 48);
			this.LNR_Button.Name = "LNR_Button";
			this.LNR_Button.Size = new System.Drawing.Size(75, 23);
			this.LNR_Button.TabIndex = 1;
			this.LNR_Button.Text = "LNR";
			this.LNR_Button.UseVisualStyleBackColor = true;
			this.LNR_Button.Click += new System.EventHandler(this.LNR_Button_Click);
			// 
			// LRN_Button
			// 
			this.LRN_Button.Location = new System.Drawing.Point(6, 78);
			this.LRN_Button.Name = "LRN_Button";
			this.LRN_Button.Size = new System.Drawing.Size(75, 23);
			this.LRN_Button.TabIndex = 2;
			this.LRN_Button.Text = "LRN";
			this.LRN_Button.UseVisualStyleBackColor = true;
			this.LRN_Button.Click += new System.EventHandler(this.LRN_Button_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.Total_Node_Label);
			this.groupBox4.Controls.Add(this.The_Height_Tree_TextBox);
			this.groupBox4.Controls.Add(this.Total_Intermediate_Node_TextBox);
			this.groupBox4.Controls.Add(this.Total_Leaf_Node_TextBox);
			this.groupBox4.Controls.Add(this.Total_Node_TextBox);
			this.groupBox4.Controls.Add(this.The_Height_Tree_Label);
			this.groupBox4.Controls.Add(this.Intermediate_Node_Label);
			this.groupBox4.Controls.Add(this.Leaf_Node_Label);
			this.groupBox4.Controls.Add(this.Way_RichTextBox);
			this.groupBox4.Location = new System.Drawing.Point(342, 532);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(756, 119);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Info";
			// 
			// Total_Node_Label
			// 
			this.Total_Node_Label.AutoSize = true;
			this.Total_Node_Label.Location = new System.Drawing.Point(6, 16);
			this.Total_Node_Label.Name = "Total_Node_Label";
			this.Total_Node_Label.Size = new System.Drawing.Size(60, 13);
			this.Total_Node_Label.TabIndex = 11;
			this.Total_Node_Label.Text = "Total Node";
			// 
			// The_Height_Tree_TextBox
			// 
			this.The_Height_Tree_TextBox.Location = new System.Drawing.Point(103, 89);
			this.The_Height_Tree_TextBox.Name = "The_Height_Tree_TextBox";
			this.The_Height_Tree_TextBox.Size = new System.Drawing.Size(61, 20);
			this.The_Height_Tree_TextBox.TabIndex = 10;
			// 
			// Total_Intermediate_Node_TextBox
			// 
			this.Total_Intermediate_Node_TextBox.Location = new System.Drawing.Point(103, 63);
			this.Total_Intermediate_Node_TextBox.Name = "Total_Intermediate_Node_TextBox";
			this.Total_Intermediate_Node_TextBox.Size = new System.Drawing.Size(61, 20);
			this.Total_Intermediate_Node_TextBox.TabIndex = 9;
			// 
			// Total_Leaf_Node_TextBox
			// 
			this.Total_Leaf_Node_TextBox.Location = new System.Drawing.Point(103, 34);
			this.Total_Leaf_Node_TextBox.Name = "Total_Leaf_Node_TextBox";
			this.Total_Leaf_Node_TextBox.Size = new System.Drawing.Size(61, 20);
			this.Total_Leaf_Node_TextBox.TabIndex = 8;
			// 
			// Total_Node_TextBox
			// 
			this.Total_Node_TextBox.Location = new System.Drawing.Point(103, 8);
			this.Total_Node_TextBox.Name = "Total_Node_TextBox";
			this.Total_Node_TextBox.Size = new System.Drawing.Size(61, 20);
			this.Total_Node_TextBox.TabIndex = 7;
			// 
			// The_Height_Tree_Label
			// 
			this.The_Height_Tree_Label.AutoSize = true;
			this.The_Height_Tree_Label.Location = new System.Drawing.Point(6, 92);
			this.The_Height_Tree_Label.Name = "The_Height_Tree_Label";
			this.The_Height_Tree_Label.Size = new System.Drawing.Size(85, 13);
			this.The_Height_Tree_Label.TabIndex = 6;
			this.The_Height_Tree_Label.Text = "The Height Tree";
			// 
			// Intermediate_Node_Label
			// 
			this.Intermediate_Node_Label.AutoSize = true;
			this.Intermediate_Node_Label.Location = new System.Drawing.Point(6, 63);
			this.Intermediate_Node_Label.Name = "Intermediate_Node_Label";
			this.Intermediate_Node_Label.Size = new System.Drawing.Size(94, 13);
			this.Intermediate_Node_Label.TabIndex = 5;
			this.Intermediate_Node_Label.Text = "Intermediate Node";
			// 
			// Leaf_Node_Label
			// 
			this.Leaf_Node_Label.AutoSize = true;
			this.Leaf_Node_Label.Location = new System.Drawing.Point(6, 37);
			this.Leaf_Node_Label.Name = "Leaf_Node_Label";
			this.Leaf_Node_Label.Size = new System.Drawing.Size(57, 13);
			this.Leaf_Node_Label.TabIndex = 4;
			this.Leaf_Node_Label.Text = "Leaf Node";
			// 
			// Way_RichTextBox
			// 
			this.Way_RichTextBox.Location = new System.Drawing.Point(176, 8);
			this.Way_RichTextBox.Name = "Way_RichTextBox";
			this.Way_RichTextBox.Size = new System.Drawing.Size(574, 105);
			this.Way_RichTextBox.TabIndex = 3;
			this.Way_RichTextBox.Text = " ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1104, 659);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Main_PictureBox);
			this.Name = "Form1";
			this.Text = "Demo AVL tree";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.Main_PictureBox)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Random_NumericUpDown)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox Main_PictureBox;
		private System.Windows.Forms.TextBox Input_TextBox;
		private System.Windows.Forms.Button Del_Tree_Button;
		private System.Windows.Forms.ComboBox Speed_ComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button Find_Button;
		private System.Windows.Forms.NumericUpDown Random_NumericUpDown;
		private System.Windows.Forms.Button Del_Node_Button;
		private System.Windows.Forms.Button Random_Button;
		private System.Windows.Forms.Label N_Random_Label;
		private System.Windows.Forms.Button LRN_Button;
		private System.Windows.Forms.Button LNR_Button;
		private System.Windows.Forms.Button NLR_Button;
		private System.Windows.Forms.Label Speed_Label;
		private System.Windows.Forms.Label Total_Node_Label;
		private System.Windows.Forms.TextBox The_Height_Tree_TextBox;
		private System.Windows.Forms.TextBox Total_Intermediate_Node_TextBox;
		private System.Windows.Forms.TextBox Total_Leaf_Node_TextBox;
		private System.Windows.Forms.TextBox Total_Node_TextBox;
		private System.Windows.Forms.Label The_Height_Tree_Label;
		private System.Windows.Forms.Label Intermediate_Node_Label;
		private System.Windows.Forms.Label Leaf_Node_Label;
		private System.Windows.Forms.RichTextBox Way_RichTextBox;
	}
}

