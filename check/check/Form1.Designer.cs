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
            thêmHọcSinhToolStripMenuItem = new ToolStripMenuItem();
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
            panel_themhs = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            txt_link = new TextBox();
            label8 = new Label();
            txt_mssv = new TextBox();
            label7 = new Label();
            text_add_name = new TextBox();
            button4 = new Button();
            label5 = new Label();
            class_id = new ComboBox();
            label6 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_Body.SuspendLayout();
            panel_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel_themhs.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhSáchSinhViênToolStripMenuItem, điểmDanhToolStripMenuItem, đăngXuấtToolStripMenuItem, thốngKêToolStripMenuItem, thêmHọcSinhToolStripMenuItem });
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
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            thốngKêToolStripMenuItem.Click += thốngKêToolStripMenuItem_Click;
            // 
            // thêmHọcSinhToolStripMenuItem
            // 
            thêmHọcSinhToolStripMenuItem.Name = "thêmHọcSinhToolStripMenuItem";
            thêmHọcSinhToolStripMenuItem.Size = new Size(97, 20);
            thêmHọcSinhToolStripMenuItem.Text = "Thêm học sinh";
            thêmHọcSinhToolStripMenuItem.Click += thêmHọcSinhToolStripMenuItem_Click;
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
            panel_thongke.Location = new Point(-1, 25);
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
            button2.Click += button2_Click;
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
            button3.Click += button3_Click;
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
            // panel_themhs
            // 
            panel_themhs.Controls.Add(dateTimePicker2);
            panel_themhs.Controls.Add(label10);
            panel_themhs.Controls.Add(label9);
            panel_themhs.Controls.Add(txt_link);
            panel_themhs.Controls.Add(label8);
            panel_themhs.Controls.Add(txt_mssv);
            panel_themhs.Controls.Add(label7);
            panel_themhs.Controls.Add(text_add_name);
            panel_themhs.Controls.Add(button4);
            panel_themhs.Controls.Add(label5);
            panel_themhs.Controls.Add(class_id);
            panel_themhs.Controls.Add(label6);
            panel_themhs.Location = new Point(0, 25);
            panel_themhs.Name = "panel_themhs";
            panel_themhs.Size = new Size(800, 421);
            panel_themhs.TabIndex = 10;
            panel_themhs.Visible = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(151, 159);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(210, 23);
            dateTimePicker2.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(87, 165);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 14;
            label10.Text = "Ngày sinh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 123);
            label9.Name = "label9";
            label9.Size = new Size(29, 15);
            label9.TabIndex = 13;
            label9.Text = "Ảnh";
            // 
            // txt_link
            // 
            txt_link.Location = new Point(444, 120);
            txt_link.Name = "txt_link";
            txt_link.Size = new Size(210, 23);
            txt_link.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 84);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 11;
            label8.Text = "MSSV";
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(444, 81);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(210, 23);
            txt_mssv.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 84);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 9;
            label7.Text = "Họ và tên";
            // 
            // text_add_name
            // 
            text_add_name.Location = new Point(151, 81);
            text_add_name.Name = "text_add_name";
            text_add_name.Size = new Size(210, 23);
            text_add_name.TabIndex = 8;
            // 
            // button4
            // 
            button4.Location = new Point(353, 236);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 123);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 6;
            label5.Text = "Lớp";
            // 
            // class_id
            // 
            class_id.FormattingEnabled = true;
            class_id.Location = new Point(151, 120);
            class_id.Name = "class_id";
            class_id.Size = new Size(210, 23);
            class_id.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 10);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 3;
            label6.Text = "Thêm học sinh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_themhs);
            Controls.Add(panel_thongke);
            Controls.Add(panel1);
            Controls.Add(panel_Body);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
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
            panel_themhs.ResumeLayout(false);
            panel_themhs.PerformLayout();
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
        private ToolStripMenuItem thêmHọcSinhToolStripMenuItem;
        private Panel panel_themhs;
        private Label label11;
        private Label msg_suc;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private Label label9;
        private TextBox txt_link;
        private Label label8;
        private TextBox txt_mssv;
        private Label label7;
        private TextBox text_add_name;
        private Button button4;
        private Label label5;
        private ComboBox class_id;
        private Label label6;
    }
}
