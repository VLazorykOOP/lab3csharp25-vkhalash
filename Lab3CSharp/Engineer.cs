namespace Lab3CSharp
{
    internal class Engineer : Employee
    {
        private string discipline;

        public Engineer(string name, int age, string jobTitle, string company, decimal salary, string discipline)
        : base(name, age, jobTitle, company, salary)
        {
            this.discipline = discipline;
        }


        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Engineer: discipline: {discipline}");
        }
    }
}
