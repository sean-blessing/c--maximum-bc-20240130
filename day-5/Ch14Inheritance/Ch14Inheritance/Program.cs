namespace Ch14Inheritance {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Inheritance!");

            Employee e1 = new Employee();
            e1.EmpID = 1;
            e1.FirstName = "Same";
            e1.LastName = "Test";
            e1.BirthDate = new DateOnly(1970, 7, 7);
            e1.SendEmail("Hello");
            Console.WriteLine(e1.GetType().Name);
            Console.WriteLine(e1.ToString());
            object o1 = new object();

            Customer c1 = new Customer();
            c1.FirstName = "Test";
            c1.SendEmail("Good bye");

            Vendor v1 = new Vendor();
            v1.FirstName = "Susan";
            v1.SendEmail("Payment coming soon!");

            Manager m1= new Manager();
            m1.FirstName = "Boss";
            m1.LastName = "The";
            m1.EmpID = 1;

            //Person p1 = new Person(); // cannot create instance once abstract
            
            SendALetter(e1);
            SendALetter(c1);
            SendALetter(v1);
            SendALetter(m1);

        }
        static void SendALetter(Person p) {
            Console.WriteLine(p.FirstName, p.LastName, p.City);
        }


    }

    abstract class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }

        public virtual void SendEmail(string message) {
            Console.WriteLine($"Sending email to {FirstName} {LastName} saying {message}.");
        }

 
    }

    class Employee: Person {
        public int EmpID { get; set; }
        public DateOnly BirthDate { get; set; }
        public void Fire() {
            // fire logic
        }

        public override void SendEmail(string message) {
            Console.WriteLine($"Sending email to {FirstName} {LastName} saying {message}.");
        }
    }

    class Manager : Employee {
        public int ManagerType { get; set; }
    }

    class Customer: Person {
        public int CustomerID { get; set; }
        public decimal CreditLimit { get; set; }

        public DateOnly BirthDate { get; set; }
    }

    class Vendor: Person {

    }
}
