namespace Question1
{
    public class Employee
    {
        #region Fields

        private string firstName;
        private string lastName;
        private double salary;

        #endregion

        #region Properties

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        #endregion

        #region Construction

        public Employee(string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        #endregion

        #region Methods

        public void ShowFullName()
        {
            Console.WriteLine($"Full name is {this.FirstName} {this.LastName}");
        }

        public void ShowSalary()
        {
            Console.WriteLine($"Salary is {this.Salary}");
        }
        public void IncrementSalary(double s)
        {
            this.Salary += s;
        }

        #endregion
    }
}
