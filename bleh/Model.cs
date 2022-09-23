using System;
namespace ClassRoster
{
    public class Model
    {
        Instructor teacher = new Instructor();

        List<Student> roster = new List<Student>();

        public void AddStudent(string first, string last, string email)
        {
            Student student = new Student(first,last,email);
            this.roster.Add(student);
        }
        
        public void newTeacher(string first, string last, string contact)
        {
            teacher.FirstName = first;
            teacher.LastName = last;    
            teacher.ContactInfo = contact;

        } 
        public string write()
        {
            return "Teacher Name: " + teacher.FirstName + " " + teacher.LastName + " Contact Info:" + teacher.ContactInfo;
        }

        public string PrintRoster()
        {
            string result = "";
            foreach (Student student in roster)
            {
                result= result + student.ToString()+"\n";
            }
            return result;
        }



      

        public Model()
        {

        }
        class Person
        {
            string firstName;
            string lastName;

            public Person() //constructor
            {

            }

            public Person(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public string FirstName //property
            {
                get { return firstName; }
                set { this.firstName = value; }
            }

            public string LastName //property
            {
                get { return lastName; }
                set { this.lastName = value; }
            }



        }

        class Instructor : Person
        {
            private string contactInfo;

            public Instructor() : base()
            {
                contactInfo = "";

            }

            public Instructor(string newFirstName, string newLastName, string newContactInfo) : base(newFirstName, newLastName)
            {
                contactInfo = newContactInfo;

            }

            public Instructor newInstructor(string first, string last, string email)
            {
                return new Instructor(first, last, email);
            }



            public string ContactInfo //property
            {

                get { return contactInfo; }
                set { contactInfo = value; }

            }

            public override string ToString()
            {
                return "Instructor name: " + this.FirstName + " " + this.LastName + " Contact Info: " + this.ContactInfo;
            }



        }



        class Student : Person
        {
            private string classRank;

            public Student() : base()
            {
                classRank = "";

            }
      

            public Student(string newFirstName, string newLastName, string newClassRank) : base(newFirstName, newLastName)
            {
                classRank = newClassRank;
            }

            public Student NewStudent(string first, string last, string rank)
            {
                return new Student(first, last, rank);
            }

            public string ClassRank //property
            {

                get { return classRank; }
                set { classRank = value; }

            }

            public override string ToString()
            {
                return "Student name: " + this.FirstName + " " + this.LastName + "  Class Rank: " + this.ClassRank;
            }



        }





    }

}
