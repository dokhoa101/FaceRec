namespace check
{
    partial class Form2
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
            lb_name = new Label();
            lb_password = new Label();
            bx_name = new TextBox();
            bx_password = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            msg_error = new Label();
            msg_success = new Label();
            SuspendLayout();
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(203, 177);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(85, 15);
            lb_name.TabIndex = 0;
            lb_name.Text = "Tên đăng nhập";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(218, 225);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(57, 15);
            lb_password.TabIndex = 1;
            lb_password.Text = "Mật khẩu";
            // 
            // bx_name
            // 
            bx_name.Location = new Point(324, 174);
            bx_name.Name = "bx_name";
            bx_name.Size = new Size(255, 23);
            bx_name.TabIndex = 2;
            bx_name.Text = "tg_vohoangquan@cntt.tdtu.edu.vn";
            // 
            // bx_password
            // 
            bx_password.Location = new Point(324, 222);
            bx_password.Name = "bx_password";
            bx_password.Size = new Size(255, 23);
            bx_password.TabIndex = 3;
            bx_password.Text = "kjfhassafs";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuHighlight;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = SystemColors.InactiveBorder;
            btn_login.Location = new Point(364, 331);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 28);
            btn_login.TabIndex = 4;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 83);
            label1.Name = "label1";
            label1.Size = new Size(104, 35);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // msg_error
            // 
            msg_error.AutoSize = true;
            msg_error.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            msg_error.ForeColor = Color.IndianRed;
            msg_error.ImageAlign = ContentAlignment.MiddleLeft;
            msg_error.Location = new Point(257, 290);
            msg_error.Name = "msg_error";
            msg_error.Size = new Size(80, 21);
            msg_error.TabIndex = 6;
            msg_error.Text = "Msg_error";
            msg_error.TextAlign = ContentAlignment.MiddleCenter;
            msg_error.UseMnemonic = false;
            msg_error.Visible = false;
            // 
            // msg_success
            // 
            msg_success.AutoSize = true;
            msg_success.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            msg_success.ForeColor = Color.Blue;
            msg_success.ImageAlign = ContentAlignment.MiddleLeft;
            msg_success.Location = new Point(324, 290);
            msg_success.Name = "msg_success";
            msg_success.Size = new Size(94, 21);
            msg_success.TabIndex = 7;
            msg_success.Text = "Msg_success";
            msg_success.TextAlign = ContentAlignment.MiddleCenter;
            msg_success.UseMnemonic = false;
            msg_success.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msg_success);
            Controls.Add(msg_error);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(bx_password);
            Controls.Add(bx_name);
            Controls.Add(lb_password);
            Controls.Add(lb_name);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_name;
        private Label lb_password;
        private TextBox bx_name;
        private TextBox bx_password;
        private Button btn_login;
        private Label label1;
        private Label msg_error;
        private Label msg_success;
    }
}