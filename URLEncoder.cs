using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string ProjectName;
            string ActivityName;

            Console.Write("Please enter your Project Name \n");
            ProjectName = Console.ReadLine();

            Console.Write("Please enter your Activity Name \n");
            ActivityName = Console.ReadLine();
            string url = "https://companyserver.com/content/[ProjectName]/files/[ActivityName]/[ActivityName]Report.pdf , ProjectName, ActivityName";

        }
    }
}
