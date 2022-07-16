using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(" ┌─────────────────────────────┐");
      Console.WriteLine(" │ Welcome to Pierre's Bakery! │");
      Console.WriteLine(" └─────────────────────────────┘");
      Console.WriteLine(" ───────────────────────────────");
      Console.WriteLine("   Where you can buy            ");
      Console.WriteLine("       loaves of bread and      ");
      Console.WriteLine("           number of Pastries!  ");
      Console.WriteLine(" ───────────────────────────────");
      bool leave = false;
      Bread bread = new Bread(0);
      Pastry pastry = new Pastry(0);
      while (!leave)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("You can (menu/buy bread/buy pastry/");
        Console.WriteLine("total cost/checkout/leave)");
        string userAction = Console.ReadLine().ToLower();
        switch (userAction)
        {
          case "menu":
            PrintMenu();
            break;
          case "buy bread":
            Buy(bread);
            break;
          case "buy pastry":
            Buy(pastry);
            break;
          case "total cost":
            PrintTotal(bread, pastry);
            break;
          case "checkout":
            Checkout(bread, pastry);
            break;
          case "leave":
            leave = true;
            break;
          default:
            Console.WriteLine("Invalid action");
            break;
        }
      }
    }

    public static void PrintMenu()
    {
      Console.WriteLine(" ┌────────────────────────────┐");
      Console.WriteLine(" │            Menu            │");
      Console.WriteLine(" └────────────────────────────┘");
      Console.WriteLine("                               ");
      Console.WriteLine(" ┌───────────Bread────────────┐");
      Console.WriteLine(" │ One loaf················$5 │");
      Console.WriteLine(" │                            │");
      Console.WriteLine(" │  Every 3rd Bread is free   │");
      Console.WriteLine(" │                            │");
      Console.WriteLine(" ┌──────────Pastry────────────┐");
      Console.WriteLine(" │ One Pastry··············$2 │");
      Console.WriteLine(" │                            │");
      Console.WriteLine(" │ Every 3rd Pastry is $1 off │");
      Console.WriteLine(" │                            │");
      Console.WriteLine(" └────────────────────────────┘");
    }

    public static void Buy(BakeryItem item)
    {
      Console.WriteLine(" ─────────────────────────────────────");
      Console.WriteLine(" How many items would you like to buy?");
      Console.WriteLine(" Remember, {0}", item.GetDiscountMessage());
      int moreItem = int.Parse(Console.ReadLine());
      if (item.Count > 0)
      {
        Console.WriteLine(" Would you like to add to your previous order or reset your order?");
        Console.WriteLine(" (add) (reset)");
        bool validChoice = false;
        while (!validChoice)
        {
          string addReset = Console.ReadLine().ToLower();
          if (addReset == "add")
          {
            validChoice = true;
            Console.WriteLine(" How many more?");
            item.Count += moreItem;
          }
          else if (addReset == "reset")
          {
            validChoice = true;
            Console.WriteLine(" How many would you like to buy?");
            item.Count = moreItem;
          }
        }
      }
      else
      {
        item.Count = moreItem;
      }
    }

    public static int CalculateTotal(Bread bread, Pastry pastry)
    {
      return bread.CalculateCostWithDiscount() + pastry.CalculateCostWithDiscount();
    }

    public static void PrintTotal(Bread bread, Pastry pastry)
    {
      Console.WriteLine(" ──────────────────────────");
      Console.WriteLine(" Your total is: ");
      Console.WriteLine(" {0} loaves of bread: ${1}", bread.Count, bread.CalculateCost());
      Console.WriteLine(" With discount: ${0}", bread.CalculateCostWithDiscount());
      Console.WriteLine(" {0} pastries: ${1}", pastry.Count, pastry.CalculateCost());
      Console.WriteLine(" With discount: ${0}", pastry.CalculateCostWithDiscount());
    }

    public static void Checkout(Bread bread, Pastry pastry)
    {
      if (bread.Count > 0 || pastry.Count > 0)
      {
        Console.WriteLine(" ────────────────────────────");
        Console.WriteLine(" Thank you for your purchase!");
        Console.WriteLine(" Your total was ${0}", CalculateTotal(bread, pastry));
        bread.Count = 0;
        pastry.Count = 0;
      }
      else
      {
        Console.WriteLine(" ──────────────────");
        Console.WriteLine(" Your cart is empty");
      }
    }
  }
}