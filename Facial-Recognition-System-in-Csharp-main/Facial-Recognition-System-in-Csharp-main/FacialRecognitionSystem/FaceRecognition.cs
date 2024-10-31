

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using check;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using FacialRecognitionSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FaceRecognition
{
    internal class FaceRec : Form
    {
        //private double distance = 1E+19;
        private double distance = 5000;

        private CascadeClassifier CascadeClassifier = new CascadeClassifier(Environment.CurrentDirectory + "/Haarcascade/haarcascade_frontalface_alt.xml");

        private Image<Bgr, byte> Frame = null;

        private Capture camera;

        private Mat mat = new Mat();

        private List<Image<Gray, byte>> trainedFaces = new List<Image<Gray, byte>>();

        private List<int> PersonLabs = new List<int>();

        private bool isEnable_SaveImage = false;

        private string ImageName;

        private PictureBox PictureBox_Frame;

        private PictureBox PictureBox_smallFrame;

        private string setPersonName;

        public bool isTrained = false;

        private List<string> Names = new List<string>();

        private EigenFaceRecognizer eigenFaceRecognizer;

        private IContainer components = null;

        private DateTime timeRec; 

        public static Dictionary<string, DateTime> attendancesList = new Dictionary<string, DateTime>();

        public List<reportItem> reportData = new List<reportItem>();

        public FaceRec()
        {
            InitializeComponent();
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Image"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Image");
            }
        }

        public void getPersonName(Control label)
        {
            Timer timer = new Timer();
            timer.Tick += timer_getPersonName_Tick;
            timer.Interval = 100;
            timer.Start();
            void timer_getPersonName_Tick(object sender, EventArgs e)
            {
                label.Text = setPersonName ;
            }
        }

        public void openCamera(PictureBox pictureBox_Camera, PictureBox pictureBox_Trained)
        {
            PictureBox_Frame = pictureBox_Camera;
            PictureBox_smallFrame = pictureBox_Trained;
            camera = new Capture();
            camera.ImageGrabbed += Camera_ImageGrabbed;
            camera.Start();
        }

        public void Save_IMAGE(string imageName)
        {
            ImageName = imageName;
            isEnable_SaveImage = true;
        }

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            camera.Retrieve(mat);
            Frame = mat.ToImage<Bgr, byte>().Resize(PictureBox_Frame.Width, PictureBox_Frame.Height, Inter.Cubic);
            detectFace();
            PictureBox_Frame.Image = Frame.Bitmap;
        }

        private void TrainFromFolder(Image<Bgr, byte> inputImage)
        {
            Frame = inputImage;
            isEnable_SaveImage = true;

            detectFace();


        }

        public void UpdateTextBox()
        {
            Form2.txtbox.Clear();
            foreach (var user in attendancesList)
            {
                Form2.txtbox.AppendText($"Student: {user.Key}, Time: {user.Value.ToString("dd/MM/yyyy hh:mm:ss tt")}");

            }

        }

        private void detectFace()
        {
            Image<Bgr, byte> image = Frame.Convert<Bgr, byte>();
            Mat mat = new Mat();
            CvInvoke.CvtColor(Frame, mat, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(mat, mat);
            Rectangle[] array = CascadeClassifier.DetectMultiScale(mat, 1.01, 5);
            if (array.Length != 0)
            {
                Rectangle[] array2 = array;
                foreach (Rectangle rectangle in array2)
                {
                    CvInvoke.Rectangle(Frame, rectangle, new Bgr(Color.LimeGreen).MCvScalar, 2);
                    SaveImage(rectangle);
                    image.ROI = rectangle;
                    trainedIamge();
                    checkName(image, rectangle);
                }
            }
            else
            {
                setPersonName = "";
            }
        }

        private void SaveImage(Rectangle face)
        {
            if (isEnable_SaveImage)
            {
                Image<Bgr, byte> image = Frame.Convert<Bgr, byte>();
                image.ROI = face;
                image.Resize(100, 100, Inter.Cubic).Save(Environment.CurrentDirectory + "\\Image\\" + ImageName + ".jpg");
                isEnable_SaveImage = false;
                trainedIamge();
            }
        }

        private void trainedIamge()
        {
            try
            {
                int num = 0;
                trainedFaces.Clear();
                PersonLabs.Clear();
                Names.Clear();
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Image", "*.jpg", SearchOption.AllDirectories);
                string[] array = files;
                foreach (string text in array)
                {
                    Image<Gray, byte> item = new Image<Gray, byte>(text);
                    trainedFaces.Add(item);
                    PersonLabs.Add(num);
                    Names.Add(text);
                    num++;
                }

                eigenFaceRecognizer = new EigenFaceRecognizer(num, distance);
                eigenFaceRecognizer.Train(trainedFaces.ToArray(), PersonLabs.ToArray());
            }
            catch
            {
            }
        }

        private void checkName(Image<Bgr, byte> resultImage, Rectangle face)
        {
            try
            {
                if (isTrained)
                {
                    Image<Gray, byte> image = resultImage.Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                    CvInvoke.EqualizeHist(image, image);
                    FaceRecognizer.PredictionResult predictionResult = eigenFaceRecognizer.Predict(image);
                    if (predictionResult.Label != -1 && predictionResult.Distance < distance)
                    {
                        PictureBox_smallFrame.Image = trainedFaces[predictionResult.Label].Bitmap;


                        setPersonName = Names[predictionResult.Label].Replace(Environment.CurrentDirectory + "\\Image\\", "").Replace(".jpg", "");
                        timeRec = DateTime.Now;

                        if (!attendancesList.ContainsKey(setPersonName))
                        {
                            attendancesList[setPersonName] = timeRec;
                            UpdateTextBox();
                            Form2.UpdateData();
                        }




                        CvInvoke.PutText(Frame, setPersonName, new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.LimeGreen).MCvScalar);
                    }
                    else
                    {
                        CvInvoke.PutText(Frame, "Unknown", new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.OrangeRed).MCvScalar);
                    }
                }
            }
            catch
            {
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            if (camera != null)
            {
                camera.Stop();
                camera.Dispose(); 
                camera = null;
                
                
                
               


            }
            isTrained = false;
            isEnable_SaveImage = false; 
            attendancesList.Clear();
            PictureBox_smallFrame.Image = null;
            PictureBox_Frame.Image = null;

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(800, 450);
            base.Name = "FaceRec";
            this.Text = "FaceRec";
            base.ResumeLayout(false);
        }

        public void SelectAndProcessImages()
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Hiển thị hộp thoại chọn thư mục
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    MessageBox.Show($"Bạn đã chọn thư mục: {selectedFolder}");

                    // Đọc tất cả các file hình ảnh trong thư mục
                    ProcessImagesInFolder(selectedFolder);
                }
            }
        }

        private void ProcessImagesInFolder(string folderPath)
        {
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg")
                                                     || f.EndsWith(".png") || f.EndsWith(".bmp")
                                                     || f.EndsWith(".gif"))
                                            .ToArray();

            foreach (string imageFile in imageFiles)
            {
                Image<Bgr, byte> image = new Image<Bgr, byte>(imageFile);
                ImageName = Path.GetFileNameWithoutExtension(imageFile);

                MessageBox.Show($"Đang xử lý hình ảnh: {ImageName}");
                MessageBox.Show(Environment.CurrentDirectory);


                TrainFromFolder(image);
            }

        }
    }

}
