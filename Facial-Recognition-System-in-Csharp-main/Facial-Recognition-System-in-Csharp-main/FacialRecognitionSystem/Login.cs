using check;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static FacialRecognitionSystem.Form2;

namespace FacialRecognitionSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MongoHelper.ConnectToMongoService();

        }

        

        private async void button1_ClickAsync(object sender, EventArgs e)
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
                        new Form2(teacher).Show();
                        return;
                    }
                }
                msg_error.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                msg_error.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
