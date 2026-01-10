// using System;

// class PatientBill
// {
//     public string BillId { get; set; }
//     public string PatientName { get; set; }
//     public bool HasInsurance { get; set; }
//     public decimal ConsultationFee { get; set; }
//     public decimal LabCharges { get; set; }
//     public decimal MedicineCharges { get; set; }
//     public decimal GrossAmount { get; set; }
//     public decimal DiscountAmount { get; set; }
//     public decimal FinalPayable { get; set; }

//     public static PatientBill? LastBill;
//     public static bool HasLastBill = false;

//     public static void Func()
//     {
//         while (true)
//         {

//             Console.WriteLine("1. Create New Bill (Enter Patient Details)");
//             Console.WriteLine("2. View Last Bill");
//             Console.WriteLine("3. Clear Last Bill");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your option: ");
//             string input = Console.ReadLine();
//             if (!int.TryParse(input, out int num))
//             {
//                 Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
//                 continue;
//             }
//             switch (num)
//             {
//                 case 1:
//                     Create();
//                     break;
//                 case 2:
//                     View();
//                     break;
//                 case 3:
//                     Clear();
//                     break;
//                 case 4:
//                     return;
//                 default:
//                     Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
//                     break;
//             }
//         }
//     }

//     public static void Create()
//     {
//         Console.Write("Enter Bill Id: ");
//         string billId = Console.ReadLine();
//         if (billId == null || billId.Trim() == "")
//         {
//             Console.WriteLine("BillId cannot be empty.");
//             return;
//         }

//         Console.Write("Enter Patient Name: ");
//         string patientName = Console.ReadLine();

//         Console.Write("Is the patient insured? (Y/N): ");
//         string insuranceInput = Console.ReadLine().ToUpper();
//         bool hasInsurance = false;
//         if (insuranceInput == "Y")
//         {
//             hasInsurance = true;
//         }
//         else if (insuranceInput == "N")
//         {
//             hasInsurance = false;
//         }
//         else
//         {
//             Console.WriteLine("Invalid input for insurance. Please enter Y or N.");
//             return;
//         }

//         Console.Write("Enter Consultation Fee: ");
//         string consultationInput = Console.ReadLine();
//         if (!decimal.TryParse(consultationInput, out decimal consultationFee))
//         {
//             Console.WriteLine("Invalid Consultation Fee. Please enter a valid number.");
//             return;
//         }
//         if (consultationFee <= 0)
//         {
//             Console.WriteLine("Consultation Fee must be positive.");
//             return;
//         }

//         Console.Write("Enter Lab Charges: ");
//         string labInput = Console.ReadLine();
//         if (!decimal.TryParse(labInput, out decimal labCharges))
//         {
//             Console.WriteLine("Invalid Lab Charges. Please enter a valid number.");
//             return;
//         }
//         if (labCharges < 0)
//         {
//             Console.WriteLine("Lab Charges must be non-negative.");
//             return;
//         }

//         Console.Write("Enter Medicine Charges: ");
//         string medicineInput = Console.ReadLine();
//         if (!decimal.TryParse(medicineInput, out decimal medicineCharges))
//         {
//             Console.WriteLine("Invalid Medicine Charges. Please enter a valid number.");
//             return;
//         }
//         if (medicineCharges < 0)
//         {
//             Console.WriteLine("Medicine Charges must be non-negative.");
//             return;
//         }

//         decimal grossAmount = consultationFee + labCharges + medicineCharges;
//         decimal discountAmount = hasInsurance ? grossAmount * 0.10m : 0;
//         decimal finalPayable = grossAmount - discountAmount;

//         PatientBill bill = new PatientBill
//         {
//             BillId = billId,
//             PatientName = patientName,
//             HasInsurance = hasInsurance,
//             ConsultationFee = consultationFee,
//             LabCharges = labCharges,
//             MedicineCharges = medicineCharges,
//             GrossAmount = grossAmount,
//             DiscountAmount = discountAmount,
//             FinalPayable = finalPayable
//         };

//         LastBill = bill;
//         HasLastBill = true;

//         Console.WriteLine("Bill created successfully.");
//         Console.WriteLine($"Gross Amount: {grossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {discountAmount:F2}");
//         Console.WriteLine($"Final Payable: {finalPayable:F2}");

//     }

//     public static void View()
//     {
//         if (!HasLastBill)
//         {
//             Console.WriteLine("No bill available. Please create a new bill first.");
//             return;
//         }


//         Console.WriteLine($"BillId: {LastBill.BillId}");
//         Console.WriteLine($"Patient: {LastBill.PatientName}");
//         Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
//         Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
//         Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
//         Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
//         Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
//         Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
//         Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");

//     }

//     public static void Clear()
//     {
//         LastBill = null;
//         HasLastBill = false;
//         Console.WriteLine("Last bill cleared.");
//     }
// }
