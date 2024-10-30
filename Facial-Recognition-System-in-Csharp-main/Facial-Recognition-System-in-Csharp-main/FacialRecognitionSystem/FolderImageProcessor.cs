using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionSystem
{
    internal class FolderImageProcessor
    {
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
            // Lấy danh sách các file có định dạng hình ảnh (JPG, PNG, BMP, GIF)
            string[] imageFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.TopDirectoryOnly)
                                            .Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg")
                                                     || f.EndsWith(".png") || f.EndsWith(".bmp")
                                                     || f.EndsWith(".gif"))
                                            .ToArray();

            foreach (string imageFile in imageFiles)
            {
                // Mở từng hình ảnh
                Image image = Image.FromFile(imageFile);

                // Bạn có thể thực hiện các thao tác với hình ảnh ở đây
                MessageBox.Show($"Đang xử lý hình ảnh: {Path.GetFileName(imageFile)}");

                // Ví dụ: hiển thị hình ảnh trên PictureBox
                // PictureBox_Frame.Image = image; (Giả sử bạn có PictureBox để hiển thị)
            }
        }
    }
}
