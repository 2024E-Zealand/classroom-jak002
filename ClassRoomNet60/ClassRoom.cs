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
            Console.WriteLine("Students born in winter: " + StudentList.FindAll(x => x.Season() == "Winter").Count());
            Console.WriteLine("Students born in spring: " + StudentList.FindAll(x => x.Season() == "Spring").Count());
            Console.WriteLine("Students born in summer: " + StudentList.FindAll(x => x.Season() == "Summer").Count());
            Console.WriteLine("Students born in autumn: " + StudentList.FindAll(x => x.Season() == "Autumn").Count());
            Console.WriteLine("Students returning errors: " + StudentList.FindAll(x => x.Season() == "Error").Count());
        }
    }
}
