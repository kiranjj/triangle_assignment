using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleA2
{
    class Program
    {
        static int Tside;
        public static int ValidateInput()
        {
            int num = 0;
            while (num == 0)
            {
                Console.Write("\nPlease enter Side {0} of the Triangle: ", Tside);
                string uinput = Console.ReadLine();
                if (int.TryParse(uinput, out num) == false)
                {
                    Console.WriteLine("\nInvalid Input- Input should be a number only.");
                    num = 0;
                }
                else if (num <= 0)
                {
                    Console.WriteLine("\nInvalid Input- Number should be greater then 0.");
                    num = 0;
                }
            }
            Tside = Tside + 1;
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("---Triangle Checker---\n");
            string selected_option;
            bool isvalidoption = false;
            while (isvalidoption == false)
            {
                Console.WriteLine("\nPlease select any of the following options by pressing corresponding number and then press enter.\n");
                Console.WriteLine("1. Enter triangle dimensions.");
                Console.WriteLine("2. Exit\n");
                Console.Write("Select any option: ");
                selected_option = Console.ReadLine();

                switch (selected_option)
                {
                    case "1":
                        Program.Tside = 1;
                        int s1, s2, s3;
                        s1 = ValidateInput();
                        s2 = ValidateInput();
                        s3 = ValidateInput();
                        string result = TriangleSolver.ReportTringle(s1, s2, s3);
                        Console.WriteLine("\nThis is a {0} Triangle", result);
                        continue;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input: Enter a valid input.");
                        isvalidoption = false;
                        continue;
                }
            }
            Console.ReadKey();
        }
    }
}
