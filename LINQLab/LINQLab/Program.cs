int[] nums = new int[8] { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

int minValue = nums.Min();
Console.WriteLine($"The minimum value is {minValue}");

int maxValue = nums.Max();
Console.WriteLine($"The maximum value is {maxValue}");

int maxValueLessThenTenThousand = nums.Where(x => x < 10000).Max();
Console.WriteLine($"The maximum value less then 10000 is {maxValueLessThenTenThousand}");

List<int> valuesBetweenTenAndHundred = nums.Where(x => x >= 10 && x <= 100).ToList();
Console.WriteLine("List of Values between 10 and 100");
foreach(int number in valuesBetweenTenAndHundred)
{
    Console.WriteLine(number);
}

int evenNumbersCount = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine($"Number of even values is {evenNumbersCount}");
