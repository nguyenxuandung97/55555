using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reiewbuoi6
{
    class Student
    {
        #region Abtribute
        private string Hoten { get; set; }
        private string Masv { get; set; }
        private int Namsinh { get; set; }
        private string Diachi { get; set; }
        private float Diemtb { get; set; }
        #endregion

        #region Behavior
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap ma sinh vien: ");
            Masv = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            Namsinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            Diachi = Console.ReadLine();
            Console.WriteLine("Nhap diem tb: ");
            Diemtb = float.Parse(Console.ReadLine());
        }
        public void Hien()
        {
            Console.WriteLine("Ho ten:{0}", Hoten);
            Console.WriteLine("MASV:{0}", Masv);
            Console.WriteLine("Nam sinh:{0}", Namsinh);
            Console.WriteLine("Dia chi:{0}", Diachi);
            Console.WriteLine("Diem TB:{0}", Diemtb);
        }
        #endregion

        #region Constructor
        public Student(string ht, string masv, int namsinh, string dc, float diem)
        {
            Hoten = ht;
            Masv = masv;
            Namsinh = namsinh;
            Diachi = dc;
            Diemtb = diem;

        }
        public Student()
        {

        }
        #endregion

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap vao so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            Student sv = new Student();
            for (int i = 0; i < n; i++)
            {
                sv.Nhap();
            }
            Console.WriteLine("Thong tin sinh vien------");
            for (int i = 0; i < n; i++)
            {
                sv.Hien();
            }
            Console.ReadKey();
        }
    }
}
