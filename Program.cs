Console.WriteLine("Сумма вашего счета?");
double inputBill = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Какой процент чаевых хотите оставить?");

int inputTips = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько человек за столом?");
int inputPeople = Convert.ToInt32(Console.ReadLine());


double tips = (inputBill * inputTips) / 100;
double bill = tips + inputBill;
double amountForEach = Math.Round(bill / inputPeople, 2);


Console.WriteLine("-----ЧЕК-----");
Console.WriteLine($"Общая сумма счета: {bill}");
Console.WriteLine($"Процент чаевых: {tips}");
Console.WriteLine($"С каждого человека по: {amountForEach}");