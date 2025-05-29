namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ensures the program runs repeatedly
            bool running = true;
            //linked list containing objects of students
            LinkedList<Student> students = new LinkedList<Student>();
            //beginning of program
            while (running)
            {

                //an array with menu options
                string[] menu = { "1. Add Student", "2. Remove Student", "3. Display Students", "4. Exit" };
                Console.WriteLine("Student Management System\n");
                //navigates through array and displays it effectively
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }
                //prompts user to make a choice
                Console.WriteLine("\nChoose an option (1-4):");
                int choice = 0;
                //used for input validation
                bool success = false;
                while (!success)
                {
                    //try-catch block for format validation and exceptions. also checks if range is correct.
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        if (choice < 1 || choice > 4)
                        {
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");

                        }
                        else
                        {
                            success = true;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");

                    }
                }


                switch (choice)
                {
                    //add students to linkedlist if choice = 1
                    case 1:
                        Console.WriteLine("Adding a new student...");
                        //receives the name and ID of the student
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student ID: ");
                        string id = Console.ReadLine();
                        //add students to linked list
                        students.AddLast(new Student(name, id));
                        Console.WriteLine($"Student {name} with ID {id} added successfully.\n");
                        break;
                    case 2:
                        Console.WriteLine("Removing a student...");
                        //prompts user to enter the ID of the student to be removed
                        Console.Write("Enter student ID to remove: ");
                        string removeId = Console.ReadLine();
                        // searches for the student with the given ID in the linked list. the first student with the matching ID is removed.
                        var studentToRemove = students.FirstOrDefault(s => s.ID == removeId);
                        if (studentToRemove != null)
                        {
                            // removes the student from the linked list
                            students.Remove(studentToRemove);
                            Console.WriteLine($"Student with ID {removeId} removed successfully.\n");
                        }
                        else
                        {
                            Console.WriteLine($"No student found with ID {removeId}.\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enrolled students:");
                        // if count == 0, it displays a message saying no students are found.
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students found.\n");
                        }
                        else
                        {// if count > 0, it displays the details of each student in the linked list.
                            foreach (var student in students)
                            {
                                Console.WriteLine($"Name: {student.Name}, ID: {student.ID}\n");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program...\n");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
