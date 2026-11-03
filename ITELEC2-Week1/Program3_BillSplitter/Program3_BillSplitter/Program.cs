double totalBill = 5076.90;
int numberOfPeople = 7;

double share = totalBill / numberOfPeople;

Console.WriteLine($"Total Bill: P{totalBill}");
Console.WriteLine($"Number of People: {numberOfPeople}");
Console.WriteLine($"Each person pays: P{share:F2}");
