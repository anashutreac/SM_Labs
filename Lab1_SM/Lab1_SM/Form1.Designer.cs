namespace Lab1_SM
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flip_image = new System.Windows.Forms.Button();
            this.rotate_right = new System.Windows.Forms.Button();
            this.rotate_left = new System.Windows.Forms.Button();
            this.gray_colors = new System.Windows.Forms.Button();
            this.mirror = new System.Windows.Forms.Button();
            this.negative_colors = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(87, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(477, 255);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // flip_image
            // 
            this.flip_image.Location = new System.Drawing.Point(12, 386);
            this.flip_image.Name = "flip_image";
            this.flip_image.Size = new System.Drawing.Size(101, 23);
            this.flip_image.TabIndex = 1;
            this.flip_image.Text = "Flip Image";
            this.flip_image.UseVisualStyleBackColor = true;
            this.flip_image.Click += new System.EventHandler(this.flip_image_Click);
            // 
            // rotate_right
            // 
            this.rotate_right.Location = new System.Drawing.Point(119, 386);
            this.rotate_right.Name = "rotate_right";
            this.rotate_right.Size = new System.Drawing.Size(101, 23);
            this.rotate_right.TabIndex = 2;
            this.rotate_right.Text = "Rotate Right";
            this.rotate_right.UseVisualStyleBackColor = true;
            this.rotate_right.Click += new System.EventHandler(this.rotate_right_Click);
            // 
            // rotate_left
            // 
            this.rotate_left.Location = new System.Drawing.Point(226, 386);
            this.rotate_left.Name = "rotate_left";
            this.rotate_left.Size = new System.Drawing.Size(101, 23);
            this.rotate_left.TabIndex = 3;
            this.rotate_left.Text = "Rotate Left";
            this.rotate_left.UseVisualStyleBackColor = true;
            this.rotate_left.Click += new System.EventHandler(this.rotate_left_Click);
            // 
            // gray_colors
            // 
            this.gray_colors.Location = new System.Drawing.Point(12, 427);
            this.gray_colors.Name = "gray_colors";
            this.gray_colors.Size = new System.Drawing.Size(101, 23);
            this.gray_colors.TabIndex = 4;
            this.gray_colors.Text = "Gray Colors";
            this.gray_colors.UseVisualStyleBackColor = true;
            this.gray_colors.Click += new System.EventHandler(this.gray_colors_Click);
            // 
            // mirror
            // 
            this.mirror.Location = new System.Drawing.Point(333, 386);
            this.mirror.Name = "mirror";
            this.mirror.Size = new System.Drawing.Size(101, 23);
            this.mirror.TabIndex = 5;
            this.mirror.Text = "Mirror";
            this.mirror.UseVisualStyleBackColor = true;
            this.mirror.Click += new System.EventHandler(this.mirror_Click);
            // 
            // negative_colors
            // 
            this.negative_colors.Location = new System.Drawing.Point(333, 427);
            this.negative_colors.Name = "negative_colors";
            this.negative_colors.Size = new System.Drawing.Size(101, 23);
            this.negative_colors.TabIndex = 6;
            this.negative_colors.Text = "Negative Colors";
            this.negative_colors.UseVisualStyleBackColor = true;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(12, 345);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(101, 23);
            this.load_button.TabIndex = 7;
            this.load_button.Text = "Load Button";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(119, 345);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(101, 23);
            this.save_button.TabIndex = 8;
            this.save_button.Text = "Save Button";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(119, 427);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 45);
            this.trackBar1.TabIndex = 9;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(440, 427);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(194, 45);
            this.trackBar2.TabIndex = 10;
            // 
            // trackBar3
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 100;
            this.trackBar3.Location = new System.Drawing.Point(119, 478);
            this.trackBar1.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar3.TabIndex = 7;
            this.trackBar1.TickFrequency = 5;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
          
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(440, 478);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(194, 45);
            this.trackBar4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.negative_colors);
            this.Controls.Add(this.mirror);
            this.Controls.Add(this.gray_colors);
            this.Controls.Add(this.rotate_left);
            this.Controls.Add(this.rotate_right);
            this.Controls.Add(this.flip_image);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button flip_image;
        private System.Windows.Forms.Button rotate_right;
        private System.Windows.Forms.Button rotate_left;
        private System.Windows.Forms.Button gray_colors;
        private System.Windows.Forms.Button mirror;
        private System.Windows.Forms.Button negative_colors;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

