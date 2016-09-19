namespace XuLyAnh
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn đường dẫn file";
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(123, 10);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(325, 20);
            this.txtSrc.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(454, 8);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(89, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // picRed
            // 
            this.picRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRed.Location = new System.Drawing.Point(287, 44);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(256, 256);
            this.picRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRed.TabIndex = 3;
            this.picRed.TabStop = false;
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picOriginal.Location = new System.Drawing.Point(16, 44);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(256, 256);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 3;
            this.picOriginal.TabStop = false;
            // 
            // picBlue
            // 
            this.picBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBlue.Location = new System.Drawing.Point(287, 306);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(256, 256);
            this.picBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlue.TabIndex = 3;
            this.picBlue.TabStop = false;
            // 
            // picGreen
            // 
            this.picGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGreen.Location = new System.Drawing.Point(16, 306);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(256, 256);
            this.picGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreen.TabIndex = 3;
            this.picGreen.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(175, 568);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(183, 31);
            this.btnChart.TabIndex = 4;
            this.btnChart.Text = "Biểu đồ màu";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 611);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picOriginal);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xu ly anh";
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.Button btnChart;
    }
}

