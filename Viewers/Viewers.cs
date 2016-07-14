using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audience
{
    class Viewer
    {
        private string _name;
        private string _secondName;
        private int _age;
        private Sex _sex;
        public enum Sex
        {
            Male,
            Female
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Sex Gender
        {
            get { return _sex; }
            set { _sex = value; }
        }

        string[] arrNameFemale = new string[5] { "Amanda", "Betty", "Ella", "Gloria", "Kristina" };
        string[] arrNameMale = new string[5] { "Felix", "Conan", "Crosby", "Benjamin", "Albert" };
        string[] arrSecondName = new string[5] { "CONNER", "DARRELL", "EDISON", "GOODWIN", "HILL" };
        static Random rnd = new Random();
        public Viewer()
        {
            int mIndex = rnd.Next(0, arrNameMale.Length);
            int fIndex = rnd.Next(0, arrNameFemale.Length);
            int snIndex = rnd.Next(0, arrSecondName.Length);
            int age = rnd.Next(15, 75);
            Sex gender = (Sex)rnd.Next(2);
            if (gender.ToString() == "Male")
            {
                Name = arrNameMale[mIndex];
            }
            else
            {
                Name = arrNameFemale[fIndex];
            }
            SecondName = arrSecondName[snIndex];
            Age = age;
            Gender = gender;
        }
    }
}