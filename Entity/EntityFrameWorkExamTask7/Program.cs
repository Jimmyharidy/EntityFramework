using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EntityFrameWorkExamTask7
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            application.StartMenu();
            Console.WriteLine("//////////////////////////////////////////////////////");
            Console.ReadLine();
        }
    }
}
