using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSB_BItmap
{
    public partial class picImage : Form
    {
        private static Image Image;
        Bitmap bmp;
        public picImage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            if (bmp == null) //MessageBox.Show("Hình ảnh chưa hợp lệ!!");
            {
                txtText.Enabled = false;
                txtText.Text = "Hình ảnh chưa hợp lệ!!";
            }
            else
            {
                String kqua = LSB.Decrypt(bmp);
                if (kqua != null) txtText.Text = kqua;
                else txtText.Text = "KẾT QUẢ TỪ HỆ THỐNG: lỗi Decrypt!!!";
            }
        }
        private void btnbrow_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
            txtText.Text = "";
            lblSelect.Visible = false;
        }

        private void btnhiden_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            if (bmp == null) //MessageBox.Show("Hình ảnh chưa hợp lệ!!");
            {
                txtText.Enabled = false;
                txtText.Text = "Hình ảnh chưa hợp lệ!!";
                return;
            }
            
            String text = txtText.Text;
            if (text == "")
            {
                MessageBox.Show("Bạn phải nhập text muốn chèn!");
                return;
            }
            Bitmap kqua = LSB.Encrypt(text, bmp);
            if (kqua != null) //MessageBox.Show("Bạn đã giấu tin thành công!");
            {
                txtText.Enabled = false;
                txtText.Text = "Bạn đã giấu tin thành công!";
            }
            else //MessageBox.Show("Lỗi!!!! Hừmmmmmm");
            {
                txtText.Enabled = false;
                txtText.Text = "Lỗi!!!! Hừmmmmmm";
            }
            pictureBox1.Image = kqua;
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
            txtText.Text = "";
            lblSelect.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
            txtText.Text = "";
            lblSelect.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       private void btnSteg_Click(object sender, EventArgs e)
        {
            txtText.Enabled =true;
            btnhiden.Visible = true;
            btndecrypt.Visible = false;
        }
        private void btnDetect_Click(object sender, EventArgs e)
        {
            txtText.Enabled = false;
            btnhiden.Visible = false;
            btndecrypt.Visible = true;
        }
        private void lblSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open_dialog.FileName);
            }
            txtText.Text = "";
            lblSelect.Visible = false;
        }
    }
}
