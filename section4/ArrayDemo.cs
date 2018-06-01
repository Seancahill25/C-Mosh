using System;



namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Sean";
            var lastName = "Cahill";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "jack", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\folder1\floder2
c:\folder3\folder4";
            Console.WriteLine(text);

        }
    }
}
