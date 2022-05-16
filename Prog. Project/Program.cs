using System;

namespace Prog._Project
{   public class Restaurant
    {    
        //instance variables
        private string name;
        private string address;
        private double gratuityRate;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }//end of property 

        public string Address
        {
            get { return address; }
            set { address = value; }
        }//end of property 
        public double GratuityRate
        {
            get { return gratuityRate;}
            set 
            { 
              if (value >= 0)
                    gratuityRate = value;
              else
                    gratuityRate = 0;

            }//end of property 
        }

        //constructor 
        public Restaurant(string name,string address,double gratuityRate)
        {
            this.name = name;
            this.address = address;
            this.gratuityRate = gratuityRate;
        }//end of constructor 

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandtotal = 0;
            int people = 0;

            while(price != -1)
            {
                subtotal = subtotal + price;
                Console.WriteLine("Enter price of food item: [-1 to quit]");
                price = Convert.ToDouble(Console.ReadLine());             
            }
            Console.Write("How many people in party: ");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }
            grandtotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal: {0:C}",subtotal);
            Console.WriteLine("{0:P} Gratuity: {1:C}",gratuityRate, gratuityAmount);
            Console.WriteLine("Grand Total: {0:C}", grandtotal);

        }//end of method

    }
 
}
