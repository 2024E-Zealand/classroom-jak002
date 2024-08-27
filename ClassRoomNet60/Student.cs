using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; private set; }
        public int BirthMonth { get; private set; }
        public int Birthday { get; private set; }

        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            if (birthmonth > 0 && birthmonth < 13)
            {
                BirthMonth = birthmonth;
            }

            Birthday = birthday;
        }

        public string Season()
        {
            switch (BirthMonth)
            {
                case 12 or 1 or 2:
                        return "Winter";
                case 3 or 4 or 5:
                    return "Spring";
                case 6 or 7 or 8:
                    return "Summer";
                case 9 or 10 or 11:
                    return "Autumn";
                case 0:
                    return "Error";
            }
            return "Salt and pepper mostly";
        }
    }
}
