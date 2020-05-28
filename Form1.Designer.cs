namespace quanLyThuVien
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
            this.btnTheloai = new System.Windows.Forms.Button();
            this.btnBandoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTheloai
            // 
            this.btnTheloai.Location = new System.Drawing.Point(95, 78);
            this.btnTheloai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTheloai.Name = "btnTheloai";
            this.btnTheloai.Size = new System.Drawing.Size(202, 67);
            this.btnTheloai.TabIndex = 0;
            this.btnTheloai.Text = "Mở FORM Thể loại sách";
            this.btnTheloai.UseVisualStyleBackColor = true;
            this.btnTheloai.Click += new System.EventHandler(this.btnTheloai_Click);
            // 
            // btnBandoc
            // 
            this.btnBandoc.Location = new System.Drawing.Point(95, 210);
            this.btnBandoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBandoc.Name = "btnBandoc";
            this.btnBandoc.Size = new System.Drawing.Size(202, 67);
            this.btnBandoc.TabIndex = 1;
            this.btnBandoc.Text = "Mở FORM cập nhật bạn đọc";
            this.btnBandoc.UseVisualStyleBackColor = true;
            this.btnBandoc.Click += new System.EventHandler(this.btnBandoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 395);
            this.Controls.Add(this.btnBandoc);
            this.Controls.Add(this.btnTheloai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTheloai;
        private System.Windows.Forms.Button btnBandoc;
    }
}

