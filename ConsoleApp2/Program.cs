namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            Console.Write("Enter the Department name : ");
            string departmentName = Console.ReadLine();

            int button;

            do
            {
                Console.WriteLine("\nChoose operation");
                Console.WriteLine("1. Create worker" +
                    "\n2. Search worker for name" +
                    "\n3. Search worker for experience " +
                    "\n4. Show all workers" +
                    "\n0. End of the program");
                button = int.Parse(Console.ReadLine());

                switch (button)
                {
                    case 1:
                        department.AddWorker(CreateWorker());
                        break;
                    case 2:
                        Console.WriteLine("Enter name : ");
                        string name = Console.ReadLine();
                         department.SearchWorker(name) ; 
                        break;
                    case 3:
                        Console.WriteLine("Enter Minumum Experience : ");
                        byte minEx = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Maximum Experience : ");
                        byte maxEx = byte.Parse(Console.ReadLine());
                        
                        department.SearchWorker(minEx, maxEx);
                        break;
                    case 4:
                        department.ShowAllWorkers();
                        break;
                    default:
                        break;
                }
            } while (button != 0);
        }



        public static Worker CreateWorker()
        {
            Worker worker = null;
            string name;
            string name1;
            string surname;
            string surname1;
            byte experience;
            string experience1;
          
                Console.WriteLine("Enter worker name : ");
                name = Console.ReadLine();
        
                Console.WriteLine("Enter worker Surname : ");
                surname = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter worker experience : ");
                experience1 = Console.ReadLine();
            } while (!byte.TryParse(experience1, out experience));

            worker = new Worker(name, surname, experience);
            return worker;
        }
    }
}