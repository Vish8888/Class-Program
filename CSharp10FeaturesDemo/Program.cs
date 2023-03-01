//// See https://aka.ms/new-console-template for more information
//PrintA();
//Console.WriteLine("Hello, World!");
//Console.ReadLine();

//static void PrintA()
//{
//    Console.WriteLine("PrintA() Called");
//}

//using CSharp10FeaturesDemo;
//global using CSharp10FeaturesDemo;

class Program
{
    static void Main()
    {
        //// CSharp10FeaturesDemo.Customer c1 = new CSharp10FeaturesDemo.Customer();
        //Customer c1 = new Customer();

        //Console.WriteLine(Customer.SiteName);
        //Console.WriteLine(Customer.SiteUrl);

        //string fn = "Vishal", ln = "Pawar";
        //Console.WriteLine($"Full Name : {fn} {ln}");

        //// Func<string> del = () => "Hello";
        //// Func<string> del = () => null;
        //// var del = () => "Hello";
        //var del = string () => null;
        //string r1 = del();

        ////var i = 10;
        ////var name = "Vishal";

        //Console.WriteLine($"{r1}, World!");

        //Student s1 = new Student() { Name = "Akash", Mobile = "8956890522" };

        //Student s1 = null;
        //if (s1 is null)
        //{
        //    Console.WriteLine("s1 is null");
        //}
        //else
        //{
        //    Console.WriteLine("s1 is not null");
        //}

        //if (s1 is { Mobile: "8956890522" })
        //{
        //    Console.WriteLine($"{s1.Mobile} number is 8956890522");
        //}

        Student s1 = new Student() { Name = "Akash", Mobile = "8956890522" };
        Console.WriteLine(s1);

        Student s2 = new Student() { Name = "Akash", Mobile = "8956890522" };
        Console.WriteLine(s2);

        // s1.Name = "Mahesh";

        if (s1 == s2)
        {
            Console.WriteLine("s1 & s2 are equal");
        }
        else
        {
            Console.WriteLine("s1 & s2 are not equal");
        }

        Student s3 = s2;
        Console.WriteLine($"{s3.Name} : {s3.Mobile}");

        Student s4 = s2 with { Name = "Mahesh" };
        Console.WriteLine($"{s4.Name} : {s4.Mobile}");

        Console.ReadLine();
    }
}