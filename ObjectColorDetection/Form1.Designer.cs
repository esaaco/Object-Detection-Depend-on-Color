namespace WindowsFormsApplication1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radio_red = new System.Windows.Forms.RadioButton();
            this.radio_blue = new System.Windows.Forms.RadioButton();
            this.radio_single_object_track = new System.Windows.Forms.RadioButton();
            this.radio_multi_obj_track = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_geometric = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radiowhite = new System.Windows.Forms.RadioButton();
            this.radi_manual_selection = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_green = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chck_dis_meter = new System.Windows.Forms.CheckBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.check_dist_coord = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chek_show_coordi = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 610);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(198, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(653, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 254);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1043, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radio_red
            // 
            this.radio_red.AutoSize = true;
            this.radio_red.ForeColor = System.Drawing.Color.Red;
            this.radio_red.Location = new System.Drawing.Point(8, 19);
            this.radio_red.Name = "radio_red";
            this.radio_red.Size = new System.Drawing.Size(59, 17);
            this.radio_red.TabIndex = 6;
            this.radio_red.TabStop = true;
            this.radio_red.Text = "Red(R)";
            this.radio_red.UseVisualStyleBackColor = true;
            this.radio_red.CheckedChanged += new System.EventHandler(this.rdiobtnKirmizi_CheckedChanged);
            // 
            // radio_blue
            // 
            this.radio_blue.AutoSize = true;
            this.radio_blue.ForeColor = System.Drawing.Color.Blue;
            this.radio_blue.Location = new System.Drawing.Point(158, 19);
            this.radio_blue.Name = "radio_blue";
            this.radio_blue.Size = new System.Drawing.Size(59, 17);
            this.radio_blue.TabIndex = 7;
            this.radio_blue.TabStop = true;
            this.radio_blue.Text = "Blue(B)";
            this.radio_blue.UseVisualStyleBackColor = true;
            // 
            // radio_single_object_track
            // 
            this.radio_single_object_track.AutoSize = true;
            this.radio_single_object_track.Location = new System.Drawing.Point(14, 24);
            this.radio_single_object_track.Name = "radio_single_object_track";
            this.radio_single_object_track.Size = new System.Drawing.Size(112, 17);
            this.radio_single_object_track.TabIndex = 8;
            this.radio_single_object_track.TabStop = true;
            this.radio_single_object_track.Text = "Single Object Trak";
            this.radio_single_object_track.UseVisualStyleBackColor = true;
            // 
            // radio_multi_obj_track
            // 
            this.radio_multi_obj_track.AutoSize = true;
            this.radio_multi_obj_track.Location = new System.Drawing.Point(132, 29);
            this.radio_multi_obj_track.Name = "radio_multi_obj_track";
            this.radio_multi_obj_track.Size = new System.Drawing.Size(125, 17);
            this.radio_multi_obj_track.TabIndex = 9;
            this.radio_multi_obj_track.TabStop = true;
            this.radio_multi_obj_track.Text = "Multiple Object Track";
            this.radio_multi_obj_track.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(274, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 110);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_geometric);
            this.groupBox2.Controls.Add(this.radio_single_object_track);
            this.groupBox2.Controls.Add(this.radio_multi_obj_track);
            this.groupBox2.Location = new System.Drawing.Point(653, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 59);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tracking Mode";
            // 
            // radio_geometric
            // 
            this.radio_geometric.AutoSize = true;
            this.radio_geometric.Location = new System.Drawing.Point(263, 29);
            this.radio_geometric.Name = "radio_geometric";
            this.radio_geometric.Size = new System.Drawing.Size(110, 17);
            this.radio_geometric.TabIndex = 13;
            this.radio_geometric.TabStop = true;
            this.radio_geometric.Text = "Geometric shapes";
            this.radio_geometric.UseVisualStyleBackColor = true;
            this.radio_geometric.CheckedChanged += new System.EventHandler(this.radio_geometric_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.trackBar3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.trackBar2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radiowhite);
            this.groupBox3.Controls.Add(this.radi_manual_selection);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radio_green);
            this.groupBox3.Controls.Add(this.radio_red);
            this.groupBox3.Controls.Add(this.radio_blue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(653, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 137);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(46, 107);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(408, 45);
            this.trackBar3.TabIndex = 23;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "255";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(45, 76);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(410, 45);
            this.trackBar2.TabIndex = 22;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "B";
            // 
            // radiowhite
            // 
            this.radiowhite.AutoSize = true;
            this.radiowhite.ForeColor = System.Drawing.Color.White;
            this.radiowhite.Location = new System.Drawing.Point(237, 19);
            this.radiowhite.Name = "radiowhite";
            this.radiowhite.Size = new System.Drawing.Size(53, 17);
            this.radiowhite.TabIndex = 25;
            this.radiowhite.TabStop = true;
            this.radiowhite.Text = "White";
            this.radiowhite.UseVisualStyleBackColor = true;
            // 
            // radi_manual_selection
            // 
            this.radi_manual_selection.AutoSize = true;
            this.radi_manual_selection.Location = new System.Drawing.Point(296, 19);
            this.radi_manual_selection.Name = "radi_manual_selection";
            this.radi_manual_selection.Size = new System.Drawing.Size(105, 17);
            this.radi_manual_selection.TabIndex = 24;
            this.radi_manual_selection.TabStop = true;
            this.radi_manual_selection.Text = "Manual Selection";
            this.radi_manual_selection.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "255";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "G";
            // 
            // radio_green
            // 
            this.radio_green.AutoSize = true;
            this.radio_green.ForeColor = System.Drawing.Color.Green;
            this.radio_green.Location = new System.Drawing.Point(73, 19);
            this.radio_green.Name = "radio_green";
            this.radio_green.Size = new System.Drawing.Size(72, 17);
            this.radio_green.TabIndex = 8;
            this.radio_green.TabStop = true;
            this.radio_green.Text = "Green (G)";
            this.radio_green.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "255";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(44, 47);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(410, 45);
            this.trackBar1.TabIndex = 21;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "R";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(17, 34);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 110);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // chck_dis_meter
            // 
            this.chck_dis_meter.AutoSize = true;
            this.chck_dis_meter.Location = new System.Drawing.Point(17, 17);
            this.chck_dis_meter.Name = "chck_dis_meter";
            this.chck_dis_meter.Size = new System.Drawing.Size(98, 17);
            this.chck_dis_meter.TabIndex = 16;
            this.chck_dis_meter.Text = "Distance Meter";
            this.chck_dis_meter.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox3.Location = new System.Drawing.Point(136, 34);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 110);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            // 
            // check_dist_coord
            // 
            this.check_dist_coord.AutoSize = true;
            this.check_dist_coord.Location = new System.Drawing.Point(136, 17);
            this.check_dist_coord.Name = "check_dist_coord";
            this.check_dist_coord.Size = new System.Drawing.Size(123, 17);
            this.check_dist_coord.TabIndex = 18;
            this.check_dist_coord.Text = "Distance Coordinate";
            this.check_dist_coord.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox3);
            this.groupBox4.Controls.Add(this.chck_dis_meter);
            this.groupBox4.Controls.Add(this.check_dist_coord);
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Controls.Add(this.chek_show_coordi);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(653, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(479, 149);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distance Tracking Mode";
            // 
            // chek_show_coordi
            // 
            this.chek_show_coordi.AutoSize = true;
            this.chek_show_coordi.Location = new System.Drawing.Point(274, 16);
            this.chek_show_coordi.Name = "chek_show_coordi";
            this.chek_show_coordi.Size = new System.Drawing.Size(108, 17);
            this.chek_show_coordi.TabIndex = 27;
            this.chek_show_coordi.Text = "Show Coordinate";
            this.chek_show_coordi.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1135, 46);
            this.label12.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(232)))));
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(1135, 669);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Object Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radio_red;
        private System.Windows.Forms.RadioButton radio_blue;
        private System.Windows.Forms.RadioButton radio_single_object_track;
        private System.Windows.Forms.RadioButton radio_multi_obj_track;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_geometric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_green;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox chck_dis_meter;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox check_dist_coord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.RadioButton radi_manual_selection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chek_show_coordi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radiowhite;
        private System.Windows.Forms.Label label12;
    }
}

