// Write a short program that prints each number from 1 to 100 on a new line.
// For each multiple of 3, print "Fizz" instead of the number. 
// For each multiple of 5, print "Buzz" instead of the number. 
// For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.

class Program
{
    static void Main ()
    {
        int[] array = Enumerable.Range(1, 100).ToArray();

        foreach (int i in array)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine ("FizzBuzz");
            }
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            if (i % 3 != 0 && i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if (i % 3 != 0 && i % 5 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}