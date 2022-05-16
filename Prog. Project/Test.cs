using Prog._Project;
public class RestaurantTest
{
    public static void Main( string[] args)
    {
        Restaurant obj = new Restaurant("Starbucks","Mahalla",.20);
        
        System.Console.WriteLine("{0}", obj.Name);
        System.Console.WriteLine("{0}", obj.Address);
        obj.GenerateReceipt();
    }
}


 
