using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using MongoDB.Driver;
using MongoDB.Bson;
using check;
using System.Collections.ObjectModel;
using Emgu.CV.UI.GLView;
using System.Xml.Linq;

namespace FacialRecognitionSystem
{
    internal partial class Form2 : Form
    {

        private static IMongoCollection<attendance> atCollection;
        private static IMongoCollection<student> stCollection;
        private static IMongoCollection<Teacher> tcCollection;
        private static IMongoCollection<Class> clCollection;
        FaceRec faceRec = new FaceRec();
        public static TextBox txtbox;
        private Teacher teacher;
        public static DateTime today = DateTime.Today; // get today
        private static ComboBox combobox;




        public Form2(Teacher teacher)
        {
            InitializeComponent();
            MongoHelper.ConnectToMongoService();

            txtbox = textBox;
            combobox = comboBox1;
            this.teacher = teacher;
        }



        private void pictureBoxCamara_Click(object sender, EventArgs e)
        {

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

        private void btnCamara_Click(object sender, EventArgs e)
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

            faceRec.openCamera(pictureBoxCamara, pictureBoxCaptured);
            btnCamara.Enabled = false;
            btnDetectFace.Enabled = true;
            btnClose.Enabled = true;
            AddData();

        }




        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCaptured_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceRec.SelectAndProcessImages();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            faceRec.Dispose();
            faceRec.isTrained = false;

            while (pictureBoxCamara.Image != null) 
            {
                pictureBoxCamara.Image = null;
                pictureBoxCaptured.Image = null;
            }
            
            
            
            

            btnCamara.Enabled = true;
        }

        public class MongoHelper
        {
            public static IMongoClient client { get; set; }
            public static IMongoDatabase database { get; set; }

            public static string MongoConnection = "mongodb+srv://nxuandao1:52200294@cluster0.oil95.mongodb.net/?retryWrites=true&w=majority";
            public static string MongoDatabase = "checkin";

            internal static void ConnectToMongoService()
            {
                try
                {
                    client = new MongoClient(MongoConnection);
                    database = client.GetDatabase(MongoDatabase);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            internal static void DisConnectToMongoService()
            {
                client = null;
                database = null;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listClassOfTeacher(sender,e);
            btnCamara.Enabled = true;
            btnDetectFace.Enabled = false;
            btnClose.Enabled = false;
        }

        private void AddData()
        {
            var className = comboBox1.SelectedItem.ToString();
            var selectedClass = clCollection.Find(x => x.className == className).FirstOrDefault(); // get selected class
            if (selectedClass == null)
            {
                MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<attendance>.Filter.And(
            Builders<attendance>.Filter.Eq("classId", selectedClass.Id),
            Builders<attendance>.Filter.Gte("createdat", today),
            Builders<attendance>.Filter.Lt("createdat", today.AddDays(1))
            );

            var existingDocument = atCollection.Find(filter).FirstOrDefault(); // get today attendance document



                       


            var studentInClass = stCollection.Find(x => x.classId.Contains(selectedClass.Id)).ToList();

            var reportArray = new List<reportItem>();
            foreach (var student in studentInClass)
            {
                var reportDoc = new reportItem
                {
                    studentid = student.Id,
                    time = null,  
                    status = null
                };

                reportArray.Add(reportDoc);
            }


            if (existingDocument != null)
            {
                //UpdateData();

            }
            else
            {
                // Nếu tài liệu không tồn tại, tạo tài liệu mới với report
                var newDocument = new attendance
                {
                    Id = ObjectId.GenerateNewId(),
                    classId = selectedClass.Id,
                    teacherid = teacher.Id,
                    createdat = (DateTime)BsonDateTime.Create(today),
                    report = reportArray
                };

                atCollection.InsertOne(newDocument);

            }




        }


        public static void UpdateData() 
        {

            
            var className = combobox.SelectedItem.ToString();

            var selectedClass = clCollection.Find(x => x.className == className).FirstOrDefault(); // get selected class

            var filter = Builders<attendance>.Filter.And(
            Builders<attendance>.Filter.Eq("classId", selectedClass.Id),
            Builders<attendance>.Filter.Gte("createdat", today),
            Builders<attendance>.Filter.Lt("createdat", today.AddDays(1))
            );

            var existingDocument = atCollection.Find(filter).FirstOrDefault();

            if (existingDocument != null) 
            {
                var studentDocs = stCollection.Find(x => existingDocument.report.Select(r => r.studentid).Contains(x.Id)).ToList();

                for (int i = 0; i < existingDocument.report.Count; i++)
                {
                    var studentId = existingDocument.report[i].studentid;
                    var studentDoc = studentDocs.FirstOrDefault(s => s.Id == studentId);

                    if (studentDoc != null && (existingDocument.report[i].status==null|| existingDocument.report[i].status == "absent"))
                    {
                        var studentName = studentDoc.name;

                        if (FaceRec.attendancesList.ContainsKey(studentName))
                        {
                            var update = Builders<attendance>.Update
                                .Set($"report.{i}.time", FaceRec.attendancesList[studentName])
                                .Set($"report.{i}.status", "present");

                            var arrayFilter = Builders<attendance>.Filter.Eq("_id", existingDocument.Id);
                            atCollection.UpdateOne(arrayFilter, update);
                        }
                    }
                }

            }


            
            
        }
    }
}
