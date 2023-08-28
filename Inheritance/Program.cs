
using Amazon;
namespace Inheritance;

class Program
{
    private static void Main(string[] args)
    {
        UseAccessModifier();
    }

    static void UseAccessModifier()
    {
        var customer = new Customer();
        // Amazon.RatingCalculator calculator = new RatingCalculator();
    }
}