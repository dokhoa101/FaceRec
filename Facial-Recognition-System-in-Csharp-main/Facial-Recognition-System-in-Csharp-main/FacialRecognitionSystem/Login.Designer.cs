namespace FacialRecognitionSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bx_name = new System.Windows.Forms.TextBox();
            this.bx_password = new System.Windows.Forms.TextBox();
            this.msg_error = new System.Windows.Forms.Label();
            this.msg_success = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 25.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // bx_name
            // 
            this.bx_name.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bx_name.Location = new System.Drawing.Point(649, 403);
            this.bx_name.Name = "bx_name";
            this.bx_name.Size = new System.Drawing.Size(462, 31);
            this.bx_name.TabIndex = 5;
            this.bx_name.Text = "tg_vohoangquan@cntt.tdtu.edu.vn";
            // 
            // bx_password
            // 
            this.bx_password.Location = new System.Drawing.Point(649, 501);
            this.bx_password.Name = "bx_password";
            this.bx_password.Size = new System.Drawing.Size(462, 31);
            this.bx_password.TabIndex = 6;
            this.bx_password.Text = "kjfhassafs";
            // 
            // msg_error
            // 
            this.msg_error.AutoSize = true;
            this.msg_error.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_error.ForeColor = System.Drawing.Color.Red;
            this.msg_error.Location = new System.Drawing.Point(468, 641);
            this.msg_error.Name = "msg_error";
            this.msg_error.Size = new System.Drawing.Size(155, 45);
            this.msg_error.TabIndex = 7;
            this.msg_error.Text = "Msg_error";
            this.msg_error.Visible = false;

            // 
            // msg_success
            // 
            this.msg_success.AutoSize = true;
            this.msg_success.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.msg_success.Location = new System.Drawing.Point(608, 641);
            this.msg_success.Name = "msg_success";
            this.msg_success.Size = new System.Drawing.Size(190, 45);
            this.msg_success.TabIndex = 9;
            this.msg_success.Text = "Msg_success";
            this.msg_success.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(690, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 89);
            this.button1.TabIndex = 10;
            this.button1.Text = "Đăng nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 969);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msg_success);
            this.Controls.Add(this.msg_error);
            this.Controls.Add(this.bx_password);
            this.Controls.Add(this.bx_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bx_name;
        private System.Windows.Forms.TextBox bx_password;
        private System.Windows.Forms.Label msg_error;
        private System.Windows.Forms.Label msg_success;
        private System.Windows.Forms.Button button1;
    }
}