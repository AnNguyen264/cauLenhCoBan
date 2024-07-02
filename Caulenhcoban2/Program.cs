using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caulenhcoban2
{
    // hàm chạy đầu tiên trong quá trình biên dịch 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello An");
            Console.WriteLine(10);
            Console.WriteLine(10.9f);
            Console.WriteLine(true); 
            int a = 5;
            Console.WriteLine("a="+a);
            //Console.WriteLine(Console.ReadLine());
           // Console.ReadKey();
            const int x = 10;// hằng là giữ nguyên giá trị và k thay đổi đc 
            Console.WriteLine(x);
            #region ep
            //ép kiểu 
            String b = "2";
            float c = float.Parse(b);// chuyển kiểu chuỗi sang số 
            float d = (float)a / 2;// chuyển từ int sang float;
            Console.WriteLine(c);
            Console.WriteLine(d);
            #endregion
            #region Parse 
            // chuyển đổi kiểu String về int giống Java
            String m = "9";
            int A=int.Parse(m);
            #endregion
            // Chuyển đổi dữ liệu 
            #region  TryParse();
            int result;
                bool isSuccess;
                string data1= "100",Data2 = "Kteam";
                isSuccess = int.TryParse(data1, out result);
                    Console.WriteLine(isSuccess== true? "Success!":"Fales");
                    Console.WriteLine("Result = " + result);
                isSuccess = int.TryParse(Data2, out result);
                    Console.WriteLine(isSuccess == true ? "Success!" : "Fales");
                    Console.WriteLine("result: " + result);
            #endregion
        }
    }
}