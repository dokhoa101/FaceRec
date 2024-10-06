using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Dynamic;
using System.ComponentModel;


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
            InitializeComponent();
            MongoHelper.ConnectToMongoService();
            this.teacher = teacher;
        }

        private Form currentFormChild;

        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentFormChild != null)
        //    {
        //        currentFormChild.Close();
        //    }
        //    currentFormChild = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    panel_Body.Controls.Add(childForm);
        //    panel_Body.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void ListStudent(object sender, EventArgs e)
        {
            //OpenChildForm(new Danhsachsinhvien());

            panel_Body.Visible = true;
            listClassOfTeacher(sender, e);
        }

        private void getClick(object sender, EventArgs e)
        {
            atCollection = MongoHelper.database.GetCollection<attendance>("attendance");
            stCollection = MongoHelper.database.GetCollection<student>("student");
            clCollection = MongoHelper.database.GetCollection<Class>("class");
            tcCollection = MongoHelper.database.GetCollection<Teacher>("teacher");

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedDate = dateTimePicker1.Value.Date;
            var className = comboBox1.SelectedItem.ToString();
            //get class and date





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

            //var classes = clCollection.Find(new BsonDocument()).ToList();
            var classes = clCollection.Find(x => classIds.Contains(x.Id)).ToList();


            if (classes.Any())
            {
                comboBox1.Items.Clear();
                foreach (var cl in classes)
                {
                    comboBox1.Items.Add(cl.className);
                }

                comboBox1.Refresh();
            }
            else
            {
                MessageBox.Show("No classes found.");
            }
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //export csv
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MongoHelper.DisConnectToMongoService();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Body.Visible = false;
            panel_thongke.Visible = true;
        }

        
    }
}
