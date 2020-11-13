//Ezequiel Laurito Nogueira 1º DAM
//calculates how many numbers of 1, 2, 3 or more digits are entered by the user until user types “end”.
using System;

class digits
{
    static void Main()
    {
        //Variable
        int oneDigitCount = 0, twoDigitCount = 0, threeDigitCount = 0, moreThatFourCount = 0;
        Console.Write("Insert a number: ");

        // read the number as string to check the word "end"
        string inputNumber = Console.ReadLine();

        while(inputNumber != "end")
        {
            int intInputNumber = Convert.ToInt32(inputNumber);
            
            if(intInputNumber != 0)
            {
                if(intInputNumber/10 == 0)
                oneDigitCount ++;  // it only has one digit
                
                else if (intInputNumber/100 == 0)
                twoDigitCount++;  // the number has 2 digits
                
                else if (intInputNumber/1000 == 0)
                threeDigitCount ++;  // the number has 3 digits
                
                else
                moreThatFourCount++;  // the number has more than 3 digits
            }
            
            inputNumber = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigitCount, twoDigitCount, threeDigitCount, moreThatFourCount); 
    }
}
