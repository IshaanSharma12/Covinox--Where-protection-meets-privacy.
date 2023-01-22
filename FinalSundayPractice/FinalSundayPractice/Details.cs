using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSundayPractice
{
    internal class Details
    {
        public string Name { get; set; }

        public string Sex { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public int Weight { get; set; }

        public double BMI
        {
            get
            {
                return Weight / Height;
            }
        }

        public int Yob
        {
            get
            {
                return 2022 - Age;
            }
        }

        public Details(string name,string sex, int age,int height, int weight)
        {
            Name = name;
            Sex = sex;
            Age = age;
            Height = height;
            Weight = weight;
            
        }

        public override string ToString()
        {
            return Name + "\t" + "\t" + Sex.PadRight(17) + "\t" + "\t" + Age.ToString() + "\t" + "\t" + Height.ToString() + "\t" + "\t" + Weight.ToString() + "\t" + "\t" + BMI.ToString() + "\t" + "\t" + Yob;
        }
    }
}
