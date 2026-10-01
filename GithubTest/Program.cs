namespace GithubTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var group = new Group() { Name = "Group1" };
            group.AddPerson(new Person() { Name = "Oleg", Age = 20 });
            group.Print();
        }
    }
}
