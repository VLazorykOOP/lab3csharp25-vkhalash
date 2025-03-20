namespace Lab3CSharp
{
    public class Person
    {
        private string name;
        private int age;

        public int Age { get { return age; } }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Person: Name: {name}, Age: {age}");
        }
    }
}
