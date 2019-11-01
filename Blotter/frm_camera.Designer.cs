namespace AppSystem
{
    partial class frm_camera
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
            this.cmd_save = new System.Windows.Forms.Button();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.cmd_capture = new System.Windows.Forms.Button();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_save
            // 
            this.cmd_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_save.Enabled = false;
            this.cmd_save.Location = new System.Drawing.Point(147, 215);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(66, 23);
            this.cmd_save.TabIndex = 9;
            this.cmd_save.Text = "&OK";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // cmd_reset
            // 
            this.cmd_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_reset.Enabled = false;
            this.cmd_reset.Location = new System.Drawing.Point(81, 215);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(66, 23);
            this.cmd_reset.TabIndex = 8;
            this.cmd_reset.Text = "Reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // cmd_capture
            // 
            this.cmd_capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_capture.Location = new System.Drawing.Point(15, 215);
            this.cmd_capture.Name = "cmd_capture";
            this.cmd_capture.Size = new System.Drawing.Size(66, 23);
            this.cmd_capture.TabIndex = 7;
            this.cmd_capture.Text = "Capture";
            this.cmd_capture.UseVisualStyleBackColor = true;
            this.cmd_capture.Click += new System.EventHandler(this.cmd_capture_Click);
            // 
            // imgCapture
            // 
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.Location = new System.Drawing.Point(8, 9);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(224, 169);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 11;
            this.imgCapture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // frm_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 253);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmd_save);
            this.Controls.Add(this.cmd_reset);
            this.Controls.Add(this.cmd_capture);
            this.Controls.Add(this.imgCapture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_camera";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_camera_FormClosing);
            this.Load += new System.EventHandler(this.frm_camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.Button cmd_reset;
        private System.Windows.Forms.Button cmd_capture;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}