using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assiment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print the second price(index 1).
            /*  double[] prices = { 25.5, 40.0, 33.75 };
                  Console.WriteLine("The Second price : "+ prices[1]); */
            #endregion

            #region Question2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and  shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            /* int[,] shelf =
             {
                 {3,5},
                 {1,4}
             };
             Console.WriteLine("Print the number of copies on shelf 1, slot 0 = "+shelf[1,0]); */

            #endregion
            #region Question3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints "Welcome to the Library!".Call it from Main.
            // PrintWelcomeMessage();
            #endregion

            #region Question4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            /*  string title = "Repanzol";
              PrintBookTitle(title);*/

            #endregion

            #region Question5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why? 
            /* int pages = 400;
             AddBonusPages(pages);
             Console.WriteLine(pages);*/
            //400
            //int is a value type. When you pass pages to AddBonusPages, the method receives a copy of the value, not the original variable.
            #endregion

            #region question6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
            /* double[] prices = { 25.5, 40.0 };
             ApplyDiscount(prices);
             //20.5
             //Array is a refrece type. 
             Console.WriteLine(prices[0]);*/
            #endregion

            #region Quetion7
            //Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
            /* int pages = 400;
             AddBonusPages( ref pages);
             Console.WriteLine(pages);*/
            //400
            //ref allows the method to modify the original variable.
            #endregion

            #region Question8
            //Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length afterward.
           /*double[] prices = { 25.5, 40.0 };
            ReplaceArray(ref prices);
            Console.WriteLine(prices.Length);*/

            #endregion


        }
        #region Question
        /* public static void PrintWelcomeMessage(){
             Console.WriteLine("Welcome to the Library!");

             }*/
        #endregion

        #region Question4
        /* public static void PrintBookTitle(string title)
         {
             Console.WriteLine("Book title: " + title); 
         }*/

        #endregion

        #region Question5
        /*  public static int AddBonusPages(int pages)
          {
              return pages + 50;
          }*/
        #endregion

        #region question6
        /* public static double ApplyDiscount(double[] prices)
          {
           return  prices[0]= prices[0] - 5;

          }*/
        #endregion

        #region  Quetion7
        /* public static int AddBonusPages(ref int pages)
           {
               return pages += 50;
           }*/
        #endregion

        #region Question8
     /*  public static void ReplaceArray(ref double[] prices)
        {
            
         prices = new double[] { 10.0, 12.5, 15.0 };

        }*/


        #endregion


    }
}

