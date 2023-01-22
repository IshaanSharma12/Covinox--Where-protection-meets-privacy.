using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurreyHospitalFormsPractice
{
    internal class Patient
    {
        public string PatientName { get; set; } 
        public int PatientID { get; set; }

        public int Patientage { get; set; }

        public Patient (string pname, int pid, int age)
        {
            PatientName = pname;
            PatientID = pid;
            Patientage = age;
        }

        public override string ToString()
        {
            string outputstr = PatientName + PatientID.ToString() + Patientage.ToString();

            return outputstr;
        }

    }
}
