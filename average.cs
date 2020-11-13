//Ezequiel Laurito Nogueira 1º DAM
//Program that calculate the average of marks introduced by user
using System;

public class Average
{
    public static void Main()
    {
        //Variable
        double total = 0, doubleNumber, quantityofNumbers = 0, totalAverage;
        string typedNumber;

        //MAIN
        Console.Write("Insert a mark: ");
        typedNumber = Console.ReadLine();	
    
        //Convert the typed name to added it and calculate the average later
        while (typedNumber != "end") 
        {  
            doubleNumber = Convert.ToDouble(typedNumber);

            quantityofNumbers++;
            
            total += doubleNumber;  

            Console.Write("Insert a mark: ");
            typedNumber = Console.ReadLine();
        }
        
        if (quantityofNumbers != 0)
        {
            totalAverage = total/quantityofNumbers;  
            Console.WriteLine("The average is {0}.",totalAverage);
        }
    }
}
