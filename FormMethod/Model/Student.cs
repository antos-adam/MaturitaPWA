using System;
namespace FormMethod.Model
{
    public class Student : Osoba
    {
        public Student(string jmeno, int vek)
        {
            Jmeno = jmeno;
            Vek = vek;
        }

        public override string ToString()
        {
            return "Student " + Jmeno + " " + Vek.ToString();
        }
    }
}

