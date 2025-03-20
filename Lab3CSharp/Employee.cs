namespace Lab3CSharp
{
    public class Employee : Worker
    {
        private string company;
        private decimal salary;

        public Employee(string name, int age, string jobTitle, string company, decimal salary) : base(name, age, jobTitle)
        {
            this.company = company;
            this.salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Employee: company: {company}, salary: {salary}");
        }
    }
}
