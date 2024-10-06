namespace check
{
    partial class Danhsachsinhvien
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
            panel_Body = new Panel();
            button1 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            getStudent = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_Body
            // 
            panel_Body.Controls.Add(button1);
            panel_Body.Controls.Add(label2);
            panel_Body.Controls.Add(comboBox1);
            panel_Body.Controls.Add(getStudent);
            panel_Body.Controls.Add(label1);
            panel_Body.Controls.Add(dataGridView1);
            panel_Body.Controls.Add(dateTimePicker1);
            panel_Body.Location = new Point(0, 15);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(800, 421);
            panel_Body.TabIndex = 5;
            panel_Body.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(725, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "In";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 12);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "Lớp";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(392, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 5;
            // 
            // getStudent
            // 
            getStudent.Location = new Point(648, 6);
            getStudent.Name = "getStudent";
            getStudent.Size = new Size(75, 23);
            getStudent.TabIndex = 4;
            getStudent.Text = "Hiển thị";
            getStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Thời gian";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 384);
            dataGridView1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2001, 1, 31, 0, 0, 0, 0);
            // 
            // Danhsachsinhvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_Body);
            Name = "Danhsachsinhvien";
            Text = "Form4";
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Body;
        private Button button1;
        private Label label2;
        private ComboBox comboBox1;
        private Button getStudent;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
    }
}