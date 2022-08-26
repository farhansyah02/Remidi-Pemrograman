using System;
namespace Program
{
    class Dosen
    {
        private int id;
        private string nama;
        private int NIK;
        private string gender;
        private string course;
        public Dosen()
        {
            this.id = 1;
            this.gender = "Laki-laki";
            this.nama = "";
            this.NIK = 1;
            this.course = "";
        }
        public void attDosen(string name, int nik)
        {
            this.nama = name;
            this.NIK = nik;
        }
        public void addCourse(string course)
        {
            this.course = course;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }
        public override string ToString()
        {
            return "ID      : " + id + "\n" +
                   "Nama    : " + nama + "\n" +
                   "NIK     : " + NIK + "\n" +
                   "Gender  : " + gender + "\n" +
                   "Course  : " + course + "\n"
                   ;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Dosen dosenku = new Dosen();
            dosenku.attDosen("Bayu Nadya Kusuma S.T, M.Eng", 21114482);
            dosenku.addCourse("Pemrograman");
            dosenku.setGender("Laki-laki");
            Console.WriteLine(dosenku.ToString());
        }
    }
}
