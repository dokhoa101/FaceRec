using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MongoHelper.ConnectToMongoService();
        }
        private async void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var collection = MongoHelper.database.GetCollection<Teacher>("teacher");
                var teachers = collection.Find(new BsonDocument()).ToList();
                foreach (var teacher in teachers)
                {
                    if (teacher.email == bx_name.Text && teacher.password == bx_password.Text)
                    {
                        msg_error.Visible = false;
                        msg_success.Text = "Đăng nhập thành công";
                        msg_success.Visible = true;
                        msg_success.ForeColor = Color.Green;
                        await Task.Delay(1000);
                        this.Hide();
                        new Form1(teacher).Show();
                        return;
                    }
                }
                msg_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                msg_error.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public class MongoHelper { 
        public static IMongoClient  client { get; set; }
        public static IMongoDatabase database { get; set; }

        public static string MongoConnection = "mongodb+srv://nxuandao1:52200294@cluster0.oil95.mongodb.net/?retryWrites=true&w=majority";
        public static string MongoDatabase = "checkin";

        internal static void ConnectToMongoService()
        {
            try
            {
                client = new MongoClient(MongoConnection);
                database = client.GetDatabase(MongoDatabase);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal static void DisConnectToMongoService()
        {
            client = null;
            database = null;
        }
    }
}
