// Bai 1
double celsiusDegree = Convert.ToDouble(Console.ReadLine());

if (celsiusDegree > 0)
{
    Console.Write("Trời Ấm");
}
else if (celsiusDegree < 0)
{
    Console.Write("Trời lạnh có thể băng giá");
}
else if (celsiusDegree == 0)
{
    Console.Write("Trời rất lạnh, đúng 0°C!");
}

// Bai 2

double income = double.Parse(Console.ReadLine() ?? "0");

double tax = 0;

if (income <= 5)
    Console.WriteLine("Miễn thuế");
else if (income <= 10)
    tax = income * 0.1;
else
    tax = income * 0.2;

if (tax > 0)
{
    Console.WriteLine($"💰 Thuế phải nộp: {tax} triệu đồng");
}

// bài 3
Console.Write("Nhập số tháng (1–12): ");
int month = int.Parse(Console.ReadLine() ?? "0");

string season;

if (month >= 1 && month <= 3)
{
    season = "Xuân";
}
else if (month >= 4 && month <= 6)
{
    season = "Hạ";
}
else if (month >= 7 && month <= 9)
{
    season = "Thu";
}
else if (month >= 10 && month <= 12)
{
    season = "Đông";
}
else
{
    season = "Tháng không hợp lệ";
}

Console.WriteLine($"Mùa: {season}");

// bài 4

Console.Write("Nhập tuổi: ");
int age = int.Parse(Console.ReadLine() ?? "0");

if (age < 18)
    Console.WriteLine("Chưa đủ tuổi tham gia NVQS");
else if (age <= 27)
    Console.WriteLine("Đủ tuổi tham gia NVQS");
else
    Console.WriteLine("Quá tuổi tham gia NVQS");

// Bài 5
Console.Write("Nhập một số nguyên: ");
int n = int.Parse(Console.ReadLine() ?? "0");

if (n < 2)
{
    Console.WriteLine("❌ Không phải số nguyên tố");
    return;
}

bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        isPrime = false;
        break;
    }
}

Console.WriteLine(isPrime ? "✅ Là số nguyên tố" : "❌ Không phải số nguyên tố");


// Bài 6
Console.Write("Nhập số điện tiêu thụ (kWh): ");
int kwh = int.Parse(Console.ReadLine() ?? "0");

int cost = 0;

if (kwh < 100)
    cost = kwh * 1500;
else if (kwh <= 200)
    cost = kwh * 2000;
else
    cost = kwh * 2500;

Console.WriteLine($"💡 Tiền điện phải trả: {cost} VND");



// Bài 7
Console.Write("Chọn hạng vé (Standard/Premium/VIP): ");
string type = Console.ReadLine()?.ToLower() ?? "";

switch (type)
{
    case "standard":
        Console.WriteLine("Ghế ngồi thường, không có đồ uống");
        break;
    case "premium":
        Console.WriteLine("Ghế ngồi thoải mái, có đồ uống miễn phí");
        break;
    case "vip":
        Console.WriteLine("Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí");
        break;
    default:
        Console.WriteLine("Loại vé không hợp lệ");
        break;
}


// Bài 8
Console.Write("Nhập số km đã đi: ");
double km = double.Parse(Console.ReadLine() ?? "0");

double costB = 0;
if (km <= 1)
    costB = 10000;
else if (km <= 5)
    costB = (10000.0 + (km - 1.0) * 8000.0);
else
    costB = 10000 + 4 * 8000 + (km - 5) * 6000;

Console.WriteLine($"Tổng tiền cước: {costB} VND");


// Bài 9 
Console.Write("Nhập 1 ký tự: ");
char c = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

if ("aeiou".Contains(c))
    Console.WriteLine("✅ Là nguyên âm");
else if (char.IsLetter(c))
    Console.WriteLine("🔠 Là phụ âm");
else
    Console.WriteLine("❌ Không phải chữ cái");

// Bài 10
Console.Write("Nhập loại vé (Economy/Business/First): ");
string ticket = Console.ReadLine()?.ToLower() ?? "";

switch (ticket)
{
    case "economy":
        Console.WriteLine("Ghế thường");
        break;
    case "business":
        Console.WriteLine("Ghế rộng");
        break;
    case "first":
        Console.WriteLine("Ghế sang trọng");
        break;
    default:
        Console.WriteLine("Loại vé không hợp lệ");
        break;
}