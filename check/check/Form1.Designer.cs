namespace check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            danhSáchSinhViênToolStripMenuItem = new ToolStripMenuItem();
            điểmDanhToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            getStudent = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            panel_Body = new Panel();
            panel_thongke = new Panel();
            button2 = new Button();
            label3 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_Body.SuspendLayout();
            panel_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchSinhViênToolStripMenuItem, điểmDanhToolStripMenuItem, đăngXuấtToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            danhSáchSinhViênToolStripMenuItem.Size = new Size(124, 20);
            danhSáchSinhViênToolStripMenuItem.Text = "Danh sách sinh viên";
            danhSáchSinhViênToolStripMenuItem.Click += ListStudent;
            // 
            // điểmDanhToolStripMenuItem
            // 
            điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            điểmDanhToolStripMenuItem.Size = new Size(77, 20);
            điểmDanhToolStripMenuItem.Text = "Điểm danh";
            điểmDanhToolStripMenuItem.Click += điểmDanhToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(73, 20);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(74, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2001, 1, 31, 0, 0, 0, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Thời gian";
            // 
            // getStudent
            // 
            getStudent.Location = new Point(648, 6);
            getStudent.Name = "getStudent";
            getStudent.Size = new Size(75, 23);
            getStudent.TabIndex = 4;
            getStudent.Text = "Hiển thị";
            getStudent.UseVisualStyleBackColor = true;
            getStudent.Click += getClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(392, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 5;
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
            // button1
            // 
            button1.Location = new Point(725, 6);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel_Body
            // 
            panel_Body.Controls.Add(panel_thongke);
            panel_Body.Controls.Add(button1);
            panel_Body.Controls.Add(label2);
            panel_Body.Controls.Add(comboBox1);
            panel_Body.Controls.Add(getStudent);
            panel_Body.Controls.Add(label1);
            panel_Body.Controls.Add(dataGridView1);
            panel_Body.Controls.Add(dateTimePicker1);
            panel_Body.Location = new Point(0, 27);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(800, 421);
            panel_Body.TabIndex = 4;
            panel_Body.Visible = false;
            // 
            // panel_thongke
            // 
            panel_thongke.Controls.Add(button2);
            panel_thongke.Controls.Add(label3);
            panel_thongke.Controls.Add(comboBox2);
            panel_thongke.Controls.Add(button3);
            panel_thongke.Controls.Add(label4);
            panel_thongke.Controls.Add(dataGridView2);
            panel_thongke.Location = new Point(0, 0);
            panel_thongke.Name = "panel_thongke";
            panel_thongke.Size = new Size(800, 421);
            panel_thongke.TabIndex = 8;
            panel_thongke.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(725, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "In";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 12);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Lớp";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(392, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 23);
            comboBox2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(648, 6);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Hiển thị";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 3;
            label4.Text = "Danh sách cấm thi";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(800, 384);
            dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel_Body);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            panel_thongke.ResumeLayout(false);
            panel_thongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private ToolStripMenuItem điểmDanhToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button getStudent;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Panel panel_Body;
        private Panel panel_thongke;
        private Button button2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button3;
        private Label label4;
        private DataGridView dataGridView2;
    }
}
