using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Complex
{
    internal class complex
    {
        private double re;
        private double im;

        public double Re
        {
            get => re;
            set => re = value;
        }

        public double Im
        {
            get => im;
            set => im = value;
        }

        // Module (độ lớn)
        public double Module => Math.Sqrt(re * re + im * im);

        // Argument (góc)
        public double Argument => Math.Atan2(im, re);

        // Constructor
        public complex(double re, double im = 0)
        {
            Re = re;
            Im = im;
        }

        public complex(string s)
        {
            if (s == "")
            {
                throw new ArgumentException("Chưa tồn tại input");
            }
            s = s.Replace(" ", ""); // bỏ khoảng trắng
            string re = "";
            string im = "";
            string temp = "";
            int mode = 0; // 0: đang đọc phần thực, 1: đang đọc phần ảo

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if ((c >= '0' && c <= '9') || c == '.' || (c == '-' && temp == "")) // số, dấu trừ đầu, hoặc dấu chấm
                {
                    temp += c;
                }
                else if (c == '+' || c == '-')
                {
                    if (mode == 0)
                    {
                        re = temp;
                        temp = c.ToString(); // bắt đầu phần ảo
                        mode = 1;
                    }
                    else
                    {
                        throw new ArgumentException("Chuỗi không hợp lệ");
                    }

                }
                else if (c == 'i')
                {
                    if (mode == 0)
                    {
                        // trường hợp chỉ có phần ảo, ví dụ "4i"
                        re = "0";
                    }
                    else if (temp == "" || temp == "-" || temp == "+")
                    {

                        im = temp += "1";
                    }
                    else
                    {
                        im = temp;
                    }
                    mode = 1;
                }
                else
                {
                    throw new ArgumentException("Chuỗi không hợp lệ");
                }
            }

            //  re = temp; // trường hợp chỉ có phần thực

            if (mode == 0)
                {
                    re = temp;
                }
            else
                {
                    im = temp;
                }
            if (im == "") im = "0";  // nếu không tìm thấy phần ảo

            Re = double.Parse(re);
            Im = double.Parse(im);
        }
        public string ToString(int precision = 5)
        {
            string reStr = Math.Round(Re, precision).ToString();
            string imStr = Math.Round(Math.Abs(Im), precision).ToString();
            if (Im < 0)
            {
                return $"{reStr} - {imStr}i";
            }
            else if (Im > 0)
            {
                return $"{reStr} + {imStr}i";
            }
            else { return reStr ; }
        }
        /// So sánh
        public static bool operator ==(complex a, complex b)
        {
            // Nếu cả 2 đều null
            if (ReferenceEquals(a, b))
                return true;

            // Nếu một cái null, một cái không
            if ((object)a == null || (object)b == null)
                return false;

            return a.Re == b.Re && a.Im == b.Im;
        }
        public static bool operator !=(complex a, complex b)
        {
            return !(a == b);
        }
        /// Cộng
        public static complex operator +(complex a, complex b)
        => new complex(a.Re + b.Re, a.Im + b.Im);

        // Trừ
        public static complex operator -(complex a, complex b)
            => new complex(a.Re - b.Re, a.Im - b.Im);

        // Nhân
        public static complex operator *(complex a, complex b)
            => new complex(a.Re * b.Re - a.Im * b.Im,
                           a.Re * b.Im + a.Im * b.Re);
        public static complex operator *(float a, complex b)
            => new complex(a * b.Re, a * b.Im);
                           
        // Chia
        public static complex operator /(complex a, complex b)
        {
            double denom = b.Re * b.Re + b.Im * b.Im;
            return new complex(
                (a.Re * b.Re + a.Im * b.Im) / denom,
                (a.Im * b.Re - a.Re * b.Im) / denom
            );
        }
        // Lấy số đối
        public static complex operator -(complex a)
        {
            return new complex(-a.Re, -a.Im);
        }
        // Lũy thừa nguyên n
        public complex Pow(int n)
        {
            double r = Math.Pow(Module, n);
            double theta = Argument * n;
            return new complex(r * Math.Cos(theta), r * Math.Sin(theta));
        }

        // Căn bậc n: trả về danh sách n nghiệm
        public List<complex> Roots(int n)
        {
            var roots = new List<complex>();
            double r = Math.Pow(Module, 1.0 / n);
            double theta = Argument;

            for (int k = 0; k < n; k++)
            {
                double angle = (theta + 2 * Math.PI * k) / n;
                roots.Add(new complex(r * Math.Cos(angle), r * Math.Sin(angle)));
            }
            return roots;
        }
    }
}
namespace Ptbac2_sothuc
{
    internal class Pt
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get => a;
            set => a = value;
        }
        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }

        // Constructor
        public Pt(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Phương thức tính nghiệm
        public (double?, double?, int) TinhNghiem()
        {
            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        return (null, null, -1);  // Vô số nghiệm
                    }
                    else
                    {
                        return (null, null, 0);   // Vô nghiệm
                    }
                }
                else
                {
                    return (-C / B, null, 1); // Bậc nhất
                }
            }

            double delta = B * B - 4 * A * C;

            if (delta < 0)
            {
                return (null, null, 0); // Vô nghiệm thực
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return (x, null, 1);
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-B + sqrtDelta) / (2 * A);
                double x2 = (-B - sqrtDelta) / (2 * A);
                return (x1, x2, 2);
            }
        }
    }
}