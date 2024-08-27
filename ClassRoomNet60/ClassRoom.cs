using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; }
        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            
        }

        public void SeasonSum()
        {
            Console.WriteLine("Students born in winter: " + StudentList.Count(x => x.Season() == "Winter"));
            Console.WriteLine("Students born in spring: " + StudentList.Count(x => x.Season() == "Spring"));
            Console.WriteLine("Students born in summer: " + StudentList.Count(x => x.Season() == "Summer"));
            Console.WriteLine("Students born in autumn: " + StudentList.Count(x => x.Season() == "Autumn"));
            Console.WriteLine("Students returning errors: " + StudentList.Count(x => x.Season() == "Error"));
        }
    }
}
