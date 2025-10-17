using System.Text.Json;

List<int> lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];

// Tính tổng các số lớn hơn 50 trong danh sách
Func<List<int>, int> totalNumberGreaterThan50 = arr =>
{
    int total = 0;
    foreach (int num in arr)
    {
        if (num > 50) total += num;
    }
    return total;
};

Console.WriteLine($@"Total of numbers greater than 50 = {totalNumberGreaterThan50(lstNumber)}");

// Tính số phần tử lớn hơn 30
Func<List<int>, int> calculateNumberGreaterThan30 = arr =>
{
    int total = 0;
    foreach (int num in arr)
    {
        if (num > 30) total += 1;
    }
    return total;
};
Console.WriteLine($@"Total of numbers greater than 30 = {calculateNumberGreaterThan30(lstNumber)}");

int max = int.MinValue;
Action<List<int>> findMax = arr =>
{
    foreach (int num in arr)
    {
        if (num > max) max = num;
    }
};
findMax(lstNumber);
Console.WriteLine($@"Max number is = {max}");


double average = 0;
Func<List<int>, double> averageOfOddNumber = arr =>
{
    foreach (int num in arr)
    {
        average += num;
    }
    return (double)average / arr.Count;
};

Console.WriteLine($@"Average odd numbers is = {averageOfOddNumber(lstNumber)}");
