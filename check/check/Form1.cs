using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Dynamic;


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

        private void ListStudent(object sender, EventArgs e)
        {
            panel2.Visible = true;
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

            atCollection = MongoHelper.database.GetCollection<attendance>("attendance");
            stCollection = MongoHelper.database.GetCollection<student>("student");
            clCollection = MongoHelper.database.GetCollection<Class>("class");

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


            var attendances = atCollection.Find(filter).ToList();

            if (attendances.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bản ghi điểm danh cho ngày đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var attendanceList = new System.Collections.Generic.List<object>();

            foreach (var attendance in attendances)
            {
                if (attendance.report != null)
                {
                    if (attendance.report is ExpandoObject reportExpando)
                    {
                        dynamic reportDynamic = reportExpando;
                        try
                        {
                            if (reportDynamic.studentid is ObjectId studentId)
                            {
                                var status = reportDynamic.status as string; if (status != null)
                                {
                                    status = (status.ToLower() == "absent" || status.ToLower() == "") ? "Vắng mặt" : "Có mặt";
                                }
                                var time = ((DateTime)reportDynamic.time).ToUniversalTime();

                                var student = stCollection.Find(x => x.Id == studentId).FirstOrDefault();
                                var studentName = student != null ? student.name : "Unknown";

                                attendanceList.Add(new
                                {
                                    StudentName = studentName,
                                    MSSV = student.MSSV,
                                    Status = status,
                                    Date = attendance.createdat.ToString("yyyy-MM-dd"),
                                    Time = time.ToString("yyyy-MM-dd HH:mm:ss")
                                });
                            }
                            else
                            {
                                Debug.WriteLine("studentid is missing or not a valid ObjectId.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error accessing report fields: {ex.Message}");
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Unexpected report format.");
                    }
                }
            }
            dataGridView1.DataSource = attendanceList;
            dataGridView1.Refresh();
        }

        private void listClassOfTeacher(object sender, EventArgs e)
        {
            clCollection = MongoHelper.database.GetCollection<Class>("class");
            var classes = clCollection.Find(x => x.teacherid == teacher.Id).ToList();
            foreach (var cl in classes)
            {
                comboBox1.Items.Add(cl.className);
            }
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
