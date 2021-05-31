
namespace KTPMUD
{
    partial class quanlinguoidung
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
            this.datanguoidung = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tracuunguoidung = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datanguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // datanguoidung
            // 
            this.datanguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datanguoidung.Location = new System.Drawing.Point(12, 92);
            this.datanguoidung.Name = "datanguoidung";
            this.datanguoidung.RowHeadersWidth = 51;
            this.datanguoidung.RowTemplate.Height = 24;
            this.datanguoidung.Size = new System.Drawing.Size(997, 346);
            this.datanguoidung.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(725, 22);
            this.textBox1.TabIndex = 1;
            // 
            // tracuunguoidung
            // 
            this.tracuunguoidung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tracuunguoidung.Location = new System.Drawing.Point(743, 6);
            this.tracuunguoidung.Name = "tracuunguoidung";
            this.tracuunguoidung.Size = new System.Drawing.Size(185, 39);
            this.tracuunguoidung.TabIndex = 2;
            this.tracuunguoidung.Text = "Tra cứu người dùng";
            this.tracuunguoidung.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(934, 6);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 80);
            this.Xoa.TabIndex = 3;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncapnhat.Location = new System.Drawing.Point(743, 51);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(185, 35);
            this.buttoncapnhat.TabIndex = 4;
            this.buttoncapnhat.Text = "Cập nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = true;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // quanlinguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 447);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.tracuunguoidung);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datanguoidung);
            this.Name = "quanlinguoidung";
            this.Text = "Quản lí người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.datanguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datanguoidung;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tracuunguoidung;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button buttoncapnhat;
    }
}