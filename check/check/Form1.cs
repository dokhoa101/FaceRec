using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Dynamic;
using System.ComponentModel;
using System.Text;


namespace check
{
    internal partial class Form1 : Form
    {
        private static IMongoCollection<attendance> atCollection;
        private static IMongoCollection<student> stCollection;
        private static IMongoCollection<Teacher> tcCollection;
        private static IMongoCollection<Class> clCollection;

        private Teacher teacher;
        public Form1(Teacher teacher)
        {
            atCollection = MongoHelper.database.GetCollection<attendance>("attendance");
            stCollection = MongoHelper.database.GetCollection<student>("student");
            clCollection = MongoHelper.database.GetCollection<Class>("class");
            tcCollection = MongoHelper.database.GetCollection<Teacher>("teacher");
            InitializeComponent();
            MongoHelper.ConnectToMongoService();
            this.teacher = teacher;
        }

        private Form currentFormChild;

        private void ListStudent(object sender, EventArgs e)
        {
            panel_themhs.Visible = false;
            panel_Body.Visible = true;
            panel_thongke.Visible = false;
            listClassOfTeacher(sender, e);
        }

        private void getClick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDate = dateTimePicker1.Value.Date;
            var className = comboBox1.SelectedItem.ToString();

            var selectedClass = clCollection.Find(x => x.className == className).FirstOrDefault();
            if (selectedClass == null)
            {
                MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedDateLocal = dateTimePicker1.Value;
            var selectedDateUtc = selectedDateLocal.ToUniversalTime();

            var startOfDayUtc = selectedDateLocal.Date.ToUniversalTime();

            var filter = Builders<attendance>.Filter.And(
                Builders<attendance>.Filter.Eq(x => x.classId, selectedClass.Id),
                Builders<attendance>.Filter.Gte(x => x.createdat, startOfDayUtc)
            );
            var attendanceList = new System.Collections.Generic.List<object>();

            var attendance = atCollection.Find(filter).FirstOrDefault();
            if (attendance == null)
            {
                MessageBox.Show("Không tìm thấy bản ghi điểm danh cho ngày đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (attendance != null && attendance.report != null)
            {
                foreach (var item in attendance.report)
                {



                    var student = stCollection.Find(x => x.Id == item.studentid).FirstOrDefault();

                    if (student != null)
                    {
                        var studentName = student != null ? student.name : "Unknown";

                        var time = item.time;
                        var MSSV = student.MSSV;
                        var status = item.status;

                        attendanceList.Add(new
                        {
                            StudentName = studentName,
                            MSSV = MSSV,
                            Status = status,
                            Date = attendance.createdat.ToString("yyyy-MM-dd"),
                            Time = time.ToString("yyyy-MM-dd HH:mm:ss")
                        });
                    }
                }
            }
            else
            {
                Console.WriteLine(" không có dữ liệu.");
            }
            dataGridView1.DataSource = attendanceList;
            dataGridView1.Refresh();
        }

        private void listClassOfTeacher(object sender, EventArgs e)
        {
            List<ObjectId> classIds = teacher.classids;
            var clCollection = MongoHelper.database.GetCollection<Class>("class");
            var classes = clCollection.Find(x => classIds.Contains(x.Id)).ToList();
            if (classes.Any())
            {
                class_id.Items.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                foreach (var cl in classes)
                {
                    class_id.Items.Add(cl.className);
                    comboBox1.Items.Add(cl.className);
                    comboBox2.Items.Add(cl.className);
                }
                class_id.Refresh();
                comboBox1.Refresh();
                comboBox2.Refresh();
            }
            else
            {
                MessageBox.Show("No classes found.");
            }
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(teacher).Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MongoHelper.DisConnectToMongoService();
            Application.Exit();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_themhs.Visible = false;
            panel_Body.Visible = false;
            panel_thongke.Visible = true;
            listClassOfTeacher(sender, e);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var className = comboBox2.SelectedItem.ToString();
            var selectedClass = clCollection.Find(x => x.className == className).FirstOrDefault();

            if (selectedClass == null)
            {
                MessageBox.Show("Không tìm thấy lớp", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var attendanceRecords = atCollection.Find(x => x.classId == selectedClass.Id).ToList();
            Dictionary<ObjectId, int> studentAbsences = new Dictionary<ObjectId, int>();

            var studentsInClass = stCollection.Find(x => x.classId.Contains(selectedClass.Id)).ToList();


            foreach (var attendance in attendanceRecords)
            {
                if (attendance.report != null && attendance.report.Any())
                {
                    foreach (var item in attendance.report)
                    {
                        if (!studentAbsences.ContainsKey(item.studentid))
                        {
                            studentAbsences[item.studentid] = 0;
                        }
                        if (item.status == "Absent" || item.status == "")
                        {
                            studentAbsences[item.studentid]++;
                        }
                    }
                }
                else
                {
                    foreach (var student in studentsInClass)
                    {
                        if (!studentAbsences.ContainsKey(student.Id))
                        {
                            studentAbsences[student.Id] = 0;
                        }
                        studentAbsences[student.Id]++;
                    }
                }
            }

            var studentsWithAbsences = new List<object>();

            foreach (var entry in studentAbsences)
            {
                if (entry.Value >= 3)
                {
                    var student = stCollection.Find(x => x.Id == entry.Key).FirstOrDefault();
                    if (student != null)
                    {
                        studentsWithAbsences.Add(new
                        {
                            MSSV = student.MSSV,
                            Name = student.name,
                            Absences = entry.Value
                        });
                    }
                }
            }

            if (studentsWithAbsences.Count > 0)
            {
                dataGridView2.DataSource = studentsWithAbsences.ToList();
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào vắng mặt quá 3 buổi.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var csvLines = new List<string>();

            var headers = dataGridView2.Columns.Cast<DataGridViewColumn>();
            csvLines.Add(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua hàng mới
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    csvLines.Add(string.Join(",", cells.Select(cell => "\"" + (cell.Value?.ToString() ?? "") + "\"")));
                }
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.FileName = "attendance_report.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ghi dữ liệu vào tệp CSV với mã hóa UTF-8 có BOM
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, csvLines, Encoding.UTF8);

                    using (var streamWriter = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(true)))
                    {
                        streamWriter.WriteLine(string.Join(Environment.NewLine, csvLines));
                    }

                    MessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var csvLines = new List<string>();

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
            csvLines.Add(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"")));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    csvLines.Add(string.Join(",", cells.Select(cell => "\"" + (cell.Value?.ToString() ?? "") + "\"")));
                }
            }
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog.FileName = "attendance_report.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Ghi dữ liệu vào tệp CSV với mã hóa UTF-8 có BOM
                    System.IO.File.WriteAllLines(saveFileDialog.FileName, csvLines, Encoding.UTF8);

                    using (var streamWriter = new StreamWriter(saveFileDialog.FileName, false, new UTF8Encoding(true)))
                    {
                        streamWriter.WriteLine(string.Join(Environment.NewLine, csvLines));
                    }

                    MessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void thêmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Body.Visible = false;
            panel_themhs.Visible = false;
            panel_themhs.Visible = true;
            listClassOfTeacher(sender, e);
        }
        private void addStudent(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(text_add_name.Text) || string.IsNullOrEmpty(txt_mssv.Text) || string.IsNullOrEmpty(txt_link.Text) || class_id.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (stCollection == null || clCollection == null)
                {
                    MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var Id = ObjectId.GenerateNewId();
                var name = text_add_name.Text;
                var MSSV = txt_mssv.Text;
                var existingStudent = stCollection.Find(x => x.MSSV == MSSV).FirstOrDefault();
                if (existingStudent != null)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var birth = dateTimePicker2.Value;
                var picture = txt_link.Text;
                var classId = new System.Collections.Generic.List<ObjectId>();
                if (class_id.SelectedItem != null)
                {
                    var classObj = clCollection
                        .Find(x => x.className == class_id.SelectedItem.ToString())
                        .FirstOrDefault();

                    if (classObj != null)
                    {
                        classId.Add(classObj.Id);
                    }
                }
                var student_add = new student
                {
                    Id = Id,
                    name = name,
                    MSSV = MSSV,
                    birth = birth,
                    picture = picture,
                    classId = classId
                };
                stCollection.InsertOne(student_add);
                MessageBox.Show("Thêm học sinh thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm học sinh: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            addStudent(sender, e);
        }
    }
}
