using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    private static Bread _bread;
    private static Pastry _pastry;
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
      _bread = new Bread(0);
      _pastry = new Pastry(0);
      while (!leave)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("You can (menu) (buy bread) (buy pastry)");
        Console.WriteLine("(calculate total cost) (checkout) (leave)");
        string userAction = Console.ReadLine().ToLower();
        switch (userAction)
        {
          case "menu":
            PrintMenu();
            break;
          case "buy bread":
            Buy("bread");
            break;
          case "buy pastry":
            Buy("pastry");
            break;
          case "calculate total cost":
            CalculateTotal();
            break;
          case "checkout":
            Checkout();
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

    public static void Buy(string type)
    {
      if (type == "bread")
      {
        Console.WriteLine("How many loaves of bread would you like to buy?");
        Console.WriteLine("Remember, {0}", Bread.GetDiscountMessage());
        int moreBread = int.Parse(Console.ReadLine());
        if (_bread.Count > 0)
        {
          Console.WriteLine("Would you like to add to your previous order or reset your order?");
          Console.WriteLine("(add) (reset)");
          bool validChoice = false;
          while (!validChoice)
          {
            string addReset = Console.ReadLine().ToLower();
            if (addReset == "add")
            {
              validChoice = true;
              Console.WriteLine("How many more?");
              _bread.Count += moreBread;
            }
            else if (addReset == "reset")
            {
              validChoice = true;
              Console.WriteLine("How many would you like to buy?");
              _bread.Count = moreBread;
            }
          }
        }
        else
        {
          _bread.Count = moreBread;
        }
      }
      else if (type == "pastry")
      {
        Console.WriteLine("How many pastries would you like to buy?");
        Console.WriteLine("Remember, {0}", Pastry.GetDiscountMessage());
        int morePastry = int.Parse(Console.ReadLine());
        if (_pastry.Count > 0)
        {
          Console.WriteLine("Would you like to add to your previous order or reset your order?");
          Console.WriteLine("(add) (reset)");
          bool validChoice = false;
          while (!validChoice)
          {
            string addReset = Console.ReadLine().ToLower();
            if (addReset == "add")
            {
              validChoice = true;
              Console.WriteLine("How many more?");
              _pastry.Count += morePastry;
            }
            else if (addReset == "reset")
            {
              validChoice = true;
              Console.WriteLine("How many would you like to buy?");
              _pastry.Count = morePastry;
            }
          }
        }
        else
        {
          _pastry.Count = morePastry;
        }
      }
    }

    public static int CalculateTotal()
    {
      Console.WriteLine("Your total is: ");
      Console.WriteLine("{0} loaves of bread: ${1}", _bread.Count, _bread.CalculateCost());
      Console.WriteLine("With discount: ${0}", _bread.CalculateCostWithDiscount());
      Console.WriteLine("{0} pastries: ${1}", _pastry.Count, _pastry.CalculateCost());
      Console.WriteLine("With discount: ${0}", _pastry.CalculateCostWithDiscount());

      return _bread.CalculateCostWithDiscount() + _pastry.CalculateCostWithDiscount();
    }

    public static void Checkout()
    {
      if (_bread.Count > 0 && _pastry.Count > 0)
      {
        Console.WriteLine("Thank you for your purchase!");
        Console.WriteLine("Your total was ${0}", CalculateTotal());
        _bread.Count = 0;
        _pastry.Count = 0;
      }
      else
      {
        Console.WriteLine("Your cart is empty");
      }
    }
  }
}