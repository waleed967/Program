using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PupilRecord
{


    class People
    {
        string _name;
        double _courseWorkMarks;
        double _examinationMarks;
    public void Record()
        {
            Console.WriteLine("Enter Student Name");
            _name = Console.ReadLine();

        }
    public void RecordOutput()
        {
  
            Console.WriteLine("Course Marks: " + _courseWorkMarks);
            Console.WriteLine("_examinationMarks: " + _examinationMarks);
        }
        
    }

    class Program
    {
       

        static void Main(string[] args)
        {

            People pe = new People();

            pe.Record();
            

            


        }
    }
}
