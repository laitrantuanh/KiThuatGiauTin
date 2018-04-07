using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSB_BItmap
{
    class LSB { 
        public enum State//biến trảng thái có thể ẩn text đc nữa hay k
        {
            yes,
            no

        };
        public static Bitmap Encrypt(String text, Bitmap bmp )
        {
            State state = State.yes;// trạng thái có thể ẩn bit trong hình ảnh
            int Char = 0;// giá trị của kí tự khi chuyển sang int
            int zeros = 0;// số lượng số 0 thêm vào khi kết thúc chương trình
            //vị trí của các kí tự trong text muốn ẩn
            int Char_index = 0;// vị trị của kí tự đang ẩn
            long pixel_index = 0;//vị trị trong pixel trong ảnh
            int R=0, G=0, B=0;// giá trị 3 màu cơ bản
            for(int i =0; i <bmp.Height; i++)
            {
                for(int j=0; j<bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j,i);// lấy pixel tại vị trí (j,i)
                    R = pixel.R - pixel.R % 2;//set LSB của R thành bit 0
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;
                    for (int n = 0; n < 3; n++)
                    {
                        if (pixel_index % 8 == 0)//ẩn đủ 1 kí tự
                        {
                            if (state == State.no && zeros == 8)//khi k đc phép ẩn thêm bit vào hình ảnh và kết thúc mess ẩn torng ảnh
                            {
                                if (((pixel_index - 1) % 3) < 2)
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));//khi chưa chèn hết 1 pixel thì đã hết text, nên phải set pixel
                                return bmp;
                            }
                            if (Char_index >= text.Length)//kitra xem chuổi đã đc ẩn hết vào ảnh hay chưa
                                state = State.no;//đánh dấu 0 để kết thúc chuỗi
                            else Char = text[Char_index++];
                        }
                        switch(pixel_index%3)
                        {
                            case 0:
                                if (state == State.yes)
                                {
                                    R += Char % 2;
                                    Char /= 2;
                                }
                                break;
                            case 1:
                                if (state == State.yes)
                                {
                                    G += Char % 2;
                                    Char /= 2;
                                }
                                break;
                            case 2:
                                if (state == State.yes)
                                {
                                    B += Char % 2;
                                    Char /= 2;
                                }
                                bmp.SetPixel(j, i, Color.FromArgb(R, G, B));//thêm vào RGB, giờ set lại gtri cho pixel trong ảnh
                                break;
                        }   
                        pixel_index++;
                        if (state == State.no)//khi k ẩn mess nữa , nếu 8bits 0 thì kết thúc
                            zeros++;
                    }
                }
            }
            return bmp;
        }

        public static String Decrypt(Bitmap Image)
        {
            String text = String.Empty;
            int Char = 0;//mã ascii của từng kí tự trong chuỗi
            long colorUnitIndex = 0;//  để lấy 8 bit từ pixel, r tính đưa ra kí tự
            for (int i = 0; i < Image.Height; i++)
            {
                for (int j = 0; j < Image.Width; j++)
                {
                    Color pixel = Image.GetPixel(j, i);// lấy điểm ảnh tại ví trí (j,i)
                    for (int k = 0; k < 3; k++)//lặp 3 lần để lấy từ R G B
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                Char = Char * 2 + pixel.R % 2;// lấy LSB của R
                                break;
                            case 1:
                                Char = Char * 2 + pixel.G % 2;
                                break;
                            case 2:
                                Char = Char * 2 + pixel.B % 2;
                                break;
                        }
                        colorUnitIndex++;
                        if (colorUnitIndex % 8 == 0)//đủ 8 bit , thì chuyển sang giá trị kí tự của text
                        {
                            Char = reverseBits(Char);//vì khi giấu bit từ phài->trái, nên khi lấy trái -> phải phải xoay ngược chuỗi lại để lấy gtri ban đầu
                            if (Char == 0)// lúc này là 8 bits 0 kí hiệu kết thúc chuỗi
                                return text;
                            char c = (char)Char;
                            text += c;
                        }
                    }
                }
            }
            return text;
        }
        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }
    }
}
