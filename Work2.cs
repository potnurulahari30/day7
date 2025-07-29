// now create two print methods one for printing (Page1 )the actual invoice and second print method (page 2) for deduction of 100% from tution fees
/*


using System;

class Admin
{
    // Delegate to calculate invoice
    public delegate int CalculateInvoice(int tuition, int transport);

    // Delegate to print invoice
    public delegate void PrintInvoice(int tuition, int transport, int total);

    // Method to calculate total invoice
    public static int GetTotal(int tuition, int transport)
    {
        return tuition + transport;
    }

    // Page 1: Actual invoice
    public static void PrintPage1(int tuition, int transport, int total)
    {
        Console.WriteLine("Page 1 - Actual Invoice");
        Console.WriteLine("Tuition Fees: " + tuition);
        Console.WriteLine("Transport Fees: " + transport);
        Console.WriteLine("Total: " + total);
    }

    // Page 2: 100% tuition fee deducted
    public static void PrintPage2(int tuition, int transport, int total)
    {
        Console.WriteLine("Page 2 - After Deduction");
        Console.WriteLine("Tuition Fees: " + tuition + " (100% waived)");
        Console.WriteLine("Transport Fees: " + transport);
        Console.WriteLine("Total: " + transport);
    }

    static void Main(string[] args)
    {
        // Assign methods to delegates
        CalculateInvoice calc = GetTotal;
        PrintInvoice print1 = PrintPage1;
        PrintInvoice print2 = PrintPage2;

        // Input fees
        int tuition = 40000;
        int transport = 8000;

        // Calculate total
        int total = calc(tuition, transport);

        // Print both versions
        print1(tuition, transport, total);
        Console.WriteLine();
        print2(tuition, transport, total);
    }
}


*/