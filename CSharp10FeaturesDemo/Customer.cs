namespace CSharp10FeaturesDemo;
public class Customer
{
    public const string SiteName = "Flipkart";
    public const string SiteUrl = $"www.{SiteName}.com";

}

//public struct Student
//{
//    public Student()
//    {

//    }
//}

public record Student
// public record struct Student
{
    public string Name { get; set; }
    public string Mobile { get; set; }
}
