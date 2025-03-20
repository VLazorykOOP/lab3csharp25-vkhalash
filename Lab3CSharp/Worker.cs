namespace Lab3CSharp
{
    public class Worker : Person
    {
        private string jobTitle;

        public Worker(string name, int age, string jobTitle) : base(name, age)
        {
            this.jobTitle = jobTitle;

        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Worker: job title: {jobTitle}");
        }
    }
}
