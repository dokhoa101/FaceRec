namespace FacialRecognitionSystem
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxCamara = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCaptured = new System.Windows.Forms.PictureBox();
            this.Openfolder = new System.Windows.Forms.Button();
            this.btnDetectFace = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(628, 70);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nhận diện khuôn mặt";
            // 
            // pictureBoxCamara
            // 
            this.pictureBoxCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamara.Location = new System.Drawing.Point(38, 186);
            this.pictureBoxCamara.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxCamara.Name = "pictureBoxCamara";
            this.pictureBoxCamara.Size = new System.Drawing.Size(992, 535);
            this.pictureBoxCamara.TabIndex = 14;
            this.pictureBoxCamara.TabStop = false;
            this.pictureBoxCamara.Click += new System.EventHandler(this.pictureBoxCamara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Camera";
            // 
            // pictureBoxCaptured
            // 
            this.pictureBoxCaptured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCaptured.Location = new System.Drawing.Point(1143, 135);
            this.pictureBoxCaptured.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxCaptured.Name = "pictureBoxCaptured";
            this.pictureBoxCaptured.Size = new System.Drawing.Size(366, 200);
            this.pictureBoxCaptured.TabIndex = 16;
            this.pictureBoxCaptured.TabStop = false;
            this.pictureBoxCaptured.Click += new System.EventHandler(this.pictureBoxCaptured_Click);
            // 
            // Openfolder
            // 
            this.Openfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Openfolder.Location = new System.Drawing.Point(796, 751);
            this.Openfolder.Margin = new System.Windows.Forms.Padding(6);
            this.Openfolder.Name = "Openfolder";
            this.Openfolder.Size = new System.Drawing.Size(234, 101);
            this.Openfolder.TabIndex = 24;
            this.Openfolder.Text = "Folder";
            this.Openfolder.UseVisualStyleBackColor = true;
            this.Openfolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDetectFace
            // 
            this.btnDetectFace.AutoSize = true;
            this.btnDetectFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectFace.Location = new System.Drawing.Point(296, 751);
            this.btnDetectFace.Margin = new System.Windows.Forms.Padding(6);
            this.btnDetectFace.Name = "btnDetectFace";
            this.btnDetectFace.Size = new System.Drawing.Size(234, 101);
            this.btnDetectFace.TabIndex = 23;
            this.btnDetectFace.Text = "Detect ";
            this.btnDetectFace.UseVisualStyleBackColor = true;
            this.btnDetectFace.Click += new System.EventHandler(this.btnDetectFace_Click);
            // 
            // btnCamara
            // 
            this.btnCamara.AutoSize = true;
            this.btnCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamara.Location = new System.Drawing.Point(38, 751);
            this.btnCamara.Margin = new System.Windows.Forms.Padding(6);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(242, 101);
            this.btnCamara.TabIndex = 21;
            this.btnCamara.Text = "Open Cam";
            this.btnCamara.UseVisualStyleBackColor = true;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(1143, 351);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(395, 501);
            this.textBox.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(546, 751);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(234, 101);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Class:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 33);
            this.comboBox1.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1586, 1015);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Openfolder);
            this.Controls.Add(this.btnDetectFace);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.pictureBoxCaptured);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCamara);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptured)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxCamara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCaptured;
        private System.Windows.Forms.Button Openfolder;
        private System.Windows.Forms.Button btnDetectFace;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}