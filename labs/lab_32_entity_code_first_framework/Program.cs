using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace lab_32_entity_code_first_framework01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello world");
            using (var db = new CollegeContext())
            {
                var student01 = new Student
                {
                    StudentID = 0001,
                    StudentName = "Amira Shah",
                    DateOfBirth = new DateTime(1994, 12, 07),
                    Height = 162,
                    Weight = 60


                };

                db.Student.Add(student01);
                db.SaveChanges();

                Console.WriteLine($"{student01.StudentID}\n{student01.StudentName}\n{student01.DateOfBirth}\n{student01.Height}\n{student01.Weight}");
            }

            List<Student> students = new List<Student>();

            using (var db = new CollegeContext())
            {
                students = db.Student.ToList<Student>();
            }

            students.ForEach(s => Console.WriteLine($"{s.StudentID}\n{s.StudentName}\n{s.DateOfBirth}\n{s.Height}\n{s.Weight}"));

        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        //constructor method: bounce responsibility back up to Entity DbContext to do all the hard work
        public CollegeContext() : base() { } //default blank

        //setting up tables for db
        public DbSet<Student> Student { get; set; }
        public DbSet<Qualification> Qualification { get; set; }

    }
}
