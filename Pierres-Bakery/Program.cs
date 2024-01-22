using System;
using System.Threading;

namespace PierreBakery
{
  class Program
  {
    static int totalBreadQuantity = 0;
    static int totalPastryQuantity = 0;

    static void Main(string[] args)
    {
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
      Console.WriteLine(ShapeTracker.UserInterfaceModels.WelcomeBanner.Welcome);
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
      Thread.Sleep(2000);
      Console.Clear();
      while (true)
      {
        Console.Write(ShapeTracker.UserInterfaceModels.BreadBanner.Bread + "\n                                                                                       Bread: Buy 2, get 1 free. A single loaf costs $5. \n Enter the number of loaves of Bread you'd like: ");
        int breadQuantity = int.Parse(Console.ReadLine());
        Thread.Sleep(500);
        Console.Clear();


        Console.Write(ShapeTracker.UserInterfaceModels.PastryBanner.Pastry + "\n                                                                                           Pastry: Buy 3, get 1 free. A single pastry costs $2.\nEnter the number of Pastries you'd like: ");
        int pastryQuantity = int.Parse(Console.ReadLine());
        Thread.Sleep(500);
        Console.Clear();


        totalBreadQuantity += breadQuantity;
        totalPastryQuantity += pastryQuantity;

        Bread bread = new Bread();
        Pastry pastry = new Pastry();

        int totalCost = bread.CalculateCost(totalBreadQuantity) + pastry.CalculateCost(totalPastryQuantity);
        Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
        Console.WriteLine($"                                                                                                             You have ordered:");
        Console.WriteLine($"                                                                                                             - {totalBreadQuantity} loaves of Bread");
        Console.WriteLine($"                                                                                                             - {totalPastryQuantity} Pastries");
        Console.WriteLine($"                                                                                                          Total cost for your order: ${totalCost}");
        Console.Write("                                                                                                          Would you like to order more? (Y/N): ");
        string continueOrder = Console.ReadLine().Trim().ToUpper();

        if (continueOrder != "Y")
        {
          Console.Clear();
          DisplayReceipt();
          break;
        }
      }
    }

    static void DisplayReceipt()
    {
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
      Console.WriteLine(ShapeTracker.UserInterfaceModels.ReceiptBanner.Receipt);
      Console.WriteLine($"                                                                                                         - {totalBreadQuantity} loaves of Bread");
      Console.WriteLine($"                                                                                                         - {totalPastryQuantity} Pastries");

      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      int totalCost = bread.CalculateCost(totalBreadQuantity) + pastry.CalculateCost(totalPastryQuantity);
      Console.WriteLine($"                                                                                                         Total cost: ${totalCost} dollars");
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
      Thread.Sleep(2500);
      Console.Clear();
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
      Console.WriteLine(ShapeTracker.UserInterfaceModels.GoodbyeBanner.Goodbye);
      Console.WriteLine(" =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");
    }
  }
}