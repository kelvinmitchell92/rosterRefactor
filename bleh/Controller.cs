using System;
namespace ClassRoster
{
    class Controller
    {


        Model model = new Model();
        View view = new View();





        public Controller()
        {


            bool choose = false;
            bool endApp = false;




            view.WriteLine("Welcome to the Class Roster Application\r");
            view.WriteLine("Enter First Name of Instructor:\n");
            string first = view.ReadLine();
            view.WriteLine("Enter Last Name of Instructor:\n");
            string last = view.ReadLine();
            view.WriteLine("Enter Email Address Name of Instructor:\n");
            string email = view.ReadLine();


            model.newTeacher(first, last, email);
            // Instructor instructor = new Instructor(first, last, email);//

            while (!endApp)
            {
                choose = false;
                view.WriteLine("Enter First Name of Student:\n");
                string first1 = view.ReadLine();
                view.WriteLine("Enter Last Name of Student:\n");
                string last1 = view.ReadLine();
                view.WriteLine("Enter Class Rank of Student:\n");
                string rank = view.ReadLine();

                model.AddStudent(first1, last1, rank);

                //roster.Add(new Student(first1, last1, rank));

                while (!choose)
                {
                    view.WriteLine("Choose an option from the following list:");
                    view.WriteLine("\ta - Add Student");
                    view.WriteLine("\tp - Print Roster");
                    view.WriteLine("\te - End Program");
                    view.WriteLine("Your option? ");

                    string next = view.ReadLine();

                    if (next == "e" || next == "E")
                    {
                        choose = true;
                        endApp = true;
                    }
                    if (next == "p" || next == "P")
                    {
                        string a = model.write();
                        view.WriteLine(a);
                        view.WriteLine(model.PrintRoster());

                        next = "";

                    }
                    if (next == "a" || next == "A")
                    {
                        choose = true;
                    }

                }
            }

            return;
        }
    }
}