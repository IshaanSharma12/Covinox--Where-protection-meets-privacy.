using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2_1175
{
    internal class Details
    {
        public string Id { get; set; }

        public String FirstName { get; set; }

        public string LastName { get; set; }

        public int Quiz { get; set; }
        public int MidTerm { get; set; }
        public int Final { get; set; }

        public int TotalCourseGrade
        {
            get
            {
                return (Quiz * 20 / 100) + (MidTerm * 30 / 100) + (Final * 50 / 100);
            }
        }

        public string LetterGrade
        {
            get
            {
                if (TotalCourseGrade < 49)
                {
                    return "F";
                }

                else if(TotalCourseGrade>49 && TotalCourseGrade < 55)
                {
                    return "P";
                }
                else if(TotalCourseGrade>55 && TotalCourseGrade < 59)
                {
                    return "C-";
                }
                else if(TotalCourseGrade>59 && TotalCourseGrade < 64)
                {
                    return "c";
                }
                else if(TotalCourseGrade>64 && TotalCourseGrade < 69)
                {
                    return "C+";
                }
                else if(TotalCourseGrade>69 && TotalCourseGrade < 74)
                {
                    return "B-";
                }
                else if(TotalCourseGrade>74 && TotalCourseGrade < 80)
                {
                    return "B";
                }
                else if(TotalCourseGrade>80 && TotalCourseGrade < 85)
                {
                    return "B+";
                }
                else if(TotalCourseGrade>85 && TotalCourseGrade < 90)
                {
                    return "A";
                }
                else if(TotalCourseGrade>90 && TotalCourseGrade < 95)
                {
                    return "A+";
                }
                else
                {
                    return "O";
                }
                
            }
        }
        public Details(string id, string fname, string lname, int quiz, int mt, int final)
        {
            Id = id;
            FirstName = fname;
            LastName= lname;
            Quiz = quiz;
            MidTerm = mt;
            Final= final;

        }

        public override string ToString()
        {
            return Id +"\t"+"\t"+ FirstName.PadRight(17) + "\t" + LastName + "\t" + "\t" + Quiz.ToString() + "\t" + "\t" + MidTerm.ToString() + "\t" + "\t" + Final.ToString() + "\t"+"\t" + TotalCourseGrade + "\t" +"\t"+"\t"+ LetterGrade;
        }

    }
}
