using Complex;

namespace Ptbac2
{
    internal class Pt_phuc
    {
        private complex a;
        private complex b;
        private complex c;

        public complex A
        {
            get => a;
            set => a = value;
        }
        public complex B
        {
            get => b;
            set => b = value;
        }
        public complex C
        {
            get => c;
            set => c = value;
        }
        // Constructor
        public Pt_phuc(complex a, complex b, complex c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Phương thức tính nghiệm
        complex O = new complex(0);
        public (complex?, complex?, float?) TinhNghiem()
        {
            if (A == O)
            {
                if (B == O)
                {
                    if (C == O)
                    {
                        return (null, null, -1);  /// Vô Số Nghiệm
                    }
                    else
                    {
                        return (null, null, 0);   /// Vô nghiệm
                    }
                }
                else
                {
                    return ((- C) / B, null, 1); // bậc nhất
                }
            }


            complex delta = B * B - 4 * A * C;
            if (delta == O)
            {
                complex x = (-B) / ( 2 * A);
                return (x, null, 1);
            }
            var roots = delta.Roots(2); // trả về (sqrt1, sqrt2)

            complex x1 = (-B + roots[0]) / (2 * A);
            complex x2 = (-B + roots[1]) / (2 * A);
            return (x1, x2, 2);

        }
    }
    internal class Pt_thuc
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
        public Pt_thuc(double a, double b, double c)
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

