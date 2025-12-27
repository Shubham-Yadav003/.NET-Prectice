using System;

class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public decimal PurchaseAmount { get; set; }
    public decimal SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public decimal ProfitOrLossAmount { get; set; }
    public decimal ProfitMarginPercent { get; set; }

    public static SaleTransaction? LastTransaction;
    public static bool HasLastTransaction = false;

    public static void Func()
    {
        while (true)
        {
           
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int num))
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                continue;
            }
            switch (num)
            {
                case 1:
                    Create();
                    break;
                case 2:
                    View();
                    break;
                case 3:
                    Calculate();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }

    public static void Create()
    {
        Console.Write("Enter Invoice No: ");
        string invoiceNo = Console.ReadLine();

        if( invoiceNo == null || invoiceNo.Trim() == "")
        {
             Console.WriteLine("Invoice No cannot be empty.");
            return;
        }

        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        string itemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        string quantityInput = Console.ReadLine();
        if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
        {
            Console.WriteLine("Quantity must be a positive integer.");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        string purchaseInput = Console.ReadLine();
        if (!decimal.TryParse(purchaseInput, out decimal purchaseAmount) || purchaseAmount <= 0)
        {
            Console.WriteLine("Purchase Amount must be a positive number.");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        string sellingInput = Console.ReadLine();
        if (!decimal.TryParse(sellingInput, out decimal sellingAmount) || sellingAmount < 0)
        {
            Console.WriteLine("Selling Amount must be non-negative.");
            return;
        }

       
        string status;
        decimal amount;
        if (sellingAmount > purchaseAmount)
        {
            status = "PROFIT";
            amount = sellingAmount - purchaseAmount;
        }
        else if (sellingAmount < purchaseAmount)
        {
            status = "LOSS";
            amount = purchaseAmount - sellingAmount;
        }
        else
        {
            status = "BREAK-EVEN";
            amount = 0;
        }
        decimal marginPercent = (amount / purchaseAmount) * 100;

        SaleTransaction transaction = new SaleTransaction
        {
            InvoiceNo = invoiceNo,
            CustomerName = customerName,
            ItemName = itemName,
            Quantity = quantity,
            PurchaseAmount = purchaseAmount,
            SellingAmount = sellingAmount,
            ProfitOrLossStatus = status,
            ProfitOrLossAmount = amount,
            ProfitMarginPercent = marginPercent
        };

        LastTransaction = transaction;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Profit/Loss Amount: {amount:F2}");
        Console.WriteLine($"Profit Margin (%): {marginPercent:F2}");
    }

    public static void View()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        
        Console.WriteLine($"Invoice No: {LastTransaction.InvoiceNo}");
        Console.WriteLine($"Customer Name: {LastTransaction.CustomerName}");
        Console.WriteLine($"Item Name: {LastTransaction.ItemName}");
        Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
        Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
        Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");
      
    }

    public static void Calculate()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        // Recompute
        decimal amount;
        string status;
        if (LastTransaction.SellingAmount > LastTransaction.PurchaseAmount)
        {
            status = "PROFIT";
            amount = LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
        }
        else if (LastTransaction.SellingAmount < LastTransaction.PurchaseAmount)
        {
            status = "LOSS";
            amount = LastTransaction.PurchaseAmount - LastTransaction.SellingAmount;
        }
        else
        {
            status = "BREAK-EVEN";
            amount = 0;
        }
        decimal marginPercent = (amount / LastTransaction.PurchaseAmount) * 100;

        
        LastTransaction.ProfitOrLossStatus = status;
        LastTransaction.ProfitOrLossAmount = amount;
        LastTransaction.ProfitMarginPercent = marginPercent;

        Console.WriteLine("Recomputed successfully.");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine($"Profit/Loss Amount: {amount:F2}");
        Console.WriteLine($"Profit Margin (%): {marginPercent:F2}");
    }
}
