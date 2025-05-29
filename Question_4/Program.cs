namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            LinkedList<Student> students = new LinkedList<Student>();
            while (running)
            {

            
            string[] menu = { "1. Add Student", "2. Remove Student", "3. Display Students", "4. Exit" };
            Console.WriteLine("Student Management System\n");
            foreach (var item in menu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nChoose an option (1-4):");
            int choice = 0;
            bool success = false;
            while (!success)
            {
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

                //add students to linkedlist if choice = 1
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding a new student...");
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student ID: ");
                        string id = Console.ReadLine();
                        students.AddLast(new Student(name, id));
                        Console.WriteLine($"Student {name} with ID {id} added successfully.\n");
                        break;
                    case 2:
                        Console.WriteLine("Removing a student...");
                        Console.Write("Enter student ID to remove: ");
                        string removeId = Console.ReadLine();
                        var studentToRemove = students.FirstOrDefault(s => s.ID == removeId);
                        if (studentToRemove != null)
                        {
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
                        if (students.Count == 0)
                        {
                            Console.WriteLine("No students found.\n");
                        }
                        else
                        {
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
