using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data.Entity; 


namespace lab_120_code_first_database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Student selectedStudent;
        


        public MainWindow()
        {
            InitializeComponent();
           
            using (var db = new CollegeContext())
            {
                var student01 = new Student
                {
                    StudentID = 0001,
                    StudentName = "Maiwand Hussain",
                    DateOfBirth = new DateTime(1994, 12, 07),
                    Height = 162,
                    Weight = 60


                };

                db.Student.Add(student01);
                db.SaveChanges();


                
            }
                  
            using (var db = new CollegeContext())
            {
                
                
                students = db.Student.ToList<Student>();
                StudentsList.ItemsSource = students;
                StudentsList.DisplayMemberPath = "StudentName";
            }

        }

        private void StudentsList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            selectedStudent = (Student)StudentsList.SelectedItem;
            List<string> studDeets = new List<string>();
            studDeets.Add(selectedStudent.StudentID.ToString());
            studDeets.Add(selectedStudent.StudentName);
            studDeets.Add(selectedStudent.DateOfBirth.ToString());
            studDeets.Add(selectedStudent.Height.ToString());
            studDeets.Add(selectedStudent.Weight.ToString());
            StudentDetails.ItemsSource = studDeets;
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
