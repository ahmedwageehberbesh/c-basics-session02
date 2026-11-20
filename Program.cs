using System.Numerics;
using System.Timers;

namespace Session2__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            Books book1 = new Books();
            book1.Id = 1;
            book1.name = "The Great Gatsby";
            book1.pages = 180;

            Books book2 = new Books();
            book2.Id = 2;
            book2.name = "The Power of Habit";
            book2.pages = 200;
            Console.WriteLine($"Book: {book1.name}, Pages: {book1.pages}");
            
            #endregion

            #region Question 2

            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine(book1.ToString());
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("book 1 == book 1: " + book1.Equals(book1));
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("book 1 == book 2: " + book1.Equals(book2));
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("book 1 hash code: " + book1.GetHashCode());
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("book 2 hash code: " + book2.GetHashCode());
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine(book1.GetType());
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine(book2.GetType());

            #endregion

            #region Question 3

            /*
            int pages = "464";

            This is a compile-time error because you cannot assign a string value to an integer variable.

            The data types are incompatible, and the compiler will flag this as an error during compilation.

            The fix is to use a compatible data type or convert the string to an integer using int.Parse() or int.TryParse().
            */

            int pages = 464;

            #endregion

            #region Question 4

            int number1 = 10;
            int number2 = 0;

            try {
                int result = number1 / number2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException )
            {
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine("Cannot divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("=".PadRight(50, '='));
                Console.WriteLine("Done");
            }


            #endregion

            #region Question 5

            pages = 300;
            double pagesInDouble = pages;

            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("Pages in double: " + pagesInDouble);

            #endregion

            #region Question 6

            double price = 49.99; 

            int priceInInt = (int)price;

            #endregion

            #region Question 7

            Console.WriteLine("=".PadRight(50, '='));
            String pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine("Pages in integer: " + pagesInt);
            Console.WriteLine("=".PadRight(50, '='));

            #endregion

            #region Question 8

            String yearText = "2023"; 

            int yearInt = int.Parse(yearText);

            String badText = "abc"; 
            
            bool isConversionSuccessful = int.TryParse(badText, out int badInt);

            Console.WriteLine("Is conversion successful: " + isConversionSuccessful);
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("Bad integer: " + badInt);
            Console.WriteLine("=".PadRight(50, '='));

            #endregion

            #region Question 9

            pages = 464;

            string pagesString = pages.ToString("N2");

            Console.WriteLine("Pages in string: " + pagesString);
            Console.WriteLine("=".PadRight(50, '='));
            #endregion

            #region Question 10

            int copies = 100; 
            object boxedCopies = copies;

            int copiesUnboxed = (int)boxedCopies;
            Console.WriteLine("Copies in object: " + boxedCopies);
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine("Copies in integer: " + copiesUnboxed);
            Console.WriteLine("=".PadRight(50, '='));
            #endregion
        }

    }
};