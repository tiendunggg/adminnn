
namespace KTPMUD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.quenmatkhau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taotaikhoan = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxmatkhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.quenmatkhau);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.taotaikhoan);
            this.panel1.Controls.Add(this.dangnhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 597);
            this.panel1.TabIndex = 0;
            // 
            // quenmatkhau
            // 
            this.quenmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quenmatkhau.Location = new System.Drawing.Point(222, 539);
            this.quenmatkhau.Name = "quenmatkhau";
            this.quenmatkhau.Size = new System.Drawing.Size(232, 48);
            this.quenmatkhau.TabIndex = 4;
            this.quenmatkhau.Text = "Quên mật khẩu";
            this.quenmatkhau.UseVisualStyleBackColor = true;
            this.quenmatkhau.Click += new System.EventHandler(this.quenmatkhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 294);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // taotaikhoan
            // 
            this.taotaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taotaikhoan.Location = new System.Drawing.Point(222, 485);
            this.taotaikhoan.Name = "taotaikhoan";
            this.taotaikhoan.Size = new System.Drawing.Size(232, 48);
            this.taotaikhoan.TabIndex = 3;
            this.taotaikhoan.Text = "Tạo tài khoản";
            this.taotaikhoan.UseVisualStyleBackColor = true;
            this.taotaikhoan.Click += new System.EventHandler(this.taotaikhoan_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.Location = new System.Drawing.Point(222, 413);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(232, 66);
            this.dangnhap.TabIndex = 2;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxmatkhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(85, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 49);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxusername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(85, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 49);
            this.panel2.TabIndex = 0;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(158, 16);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(300, 22);
            this.textBoxusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxmatkhau
            // 
            this.textBoxmatkhau.Location = new System.Drawing.Point(158, 15);
            this.textBoxmatkhau.Name = "textBoxmatkhau";
            this.textBoxmatkhau.Size = new System.Drawing.Size(300, 22);
            this.textBoxmatkhau.TabIndex = 2;
            this.textBoxmatkhau.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 622);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Button taotaikhoan;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quenmatkhau;
        private System.Windows.Forms.TextBox textBoxmatkhau;
    }
}

