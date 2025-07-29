//create a delegate for a admin who is responsible for calculating the invoice(int tutionfess , int transportfees)
//and one more delegate which will print the invoice
/*

using System;

class Admin
{
    
    public delegate int CalculateInvoice(int tuitionFees, int transportFees);

    
    public delegate void PrintInvoice(int total);


    public static int GetTotalInvoice(int tuition, int transport)
    {
        return tuition + transport;
    }

    public static void DisplayInvoice(int total)
    {
        Console.WriteLine("Total Invoice Amount: ₹" + total);
    }

    
    static void Main(string[] args)
    {
        
        CalculateInvoice calc = GetTotalInvoice;
        PrintInvoice print = DisplayInvoice;

        int tuitionFees = 60000;
        int transportFees = 10000;

        int total = calc(tuitionFees, transportFees);
        print(total);
    }
}

*/