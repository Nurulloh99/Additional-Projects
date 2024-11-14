/**
           Ikki o'lchamlik massivning har bir ustunlarini alohida - alohida yig'indilarini, 
               va shu yig'indilardan eng kottasini alohida, 
               va shu eng kotta yigindini massivdagi ustun ko'rinishini alohida pasdan,
               va shu massivdagi hamma sonlarning yig'indisidan eng kottasini, va uning i va j indekslarini alohida - alohida,
               va shu massivning hamma sonlarning yig'indisidan eng kichigini, va uning i va j indekslarini alohida - alohida,
               va eng kotta yig'indi bilan massivdagi eng oxxirgi o'rinda joylashgan son blan o'rnining almashganini,
               va eng kichik yig'indi bilan massivdagi birinchi o'rinda joylashgan son blan o'rnining almashganini chiqarib beruvchi dastur tuzing!!!'
           */


var rand = new Random();
Console.Write("Massivni o'lchamini kiriting >> ");
var number = Convert.ToInt32(Console.ReadLine());
var arr = new int[number, number];
// int[,] arr = new int[number, number];
Console.WriteLine();
for(int i = 0; i < number; i++)
{
    for(int j = 0; j < number; j++)
    {
        arr[i, j] = rand.Next(0, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();

var maxx = 0;
var index_i = 0;

for(int i = 0; i < number; i++)
{
    var summary = 0;
    for(int j = 0; j < number; j++)
    {
        summary += arr[j, i];
    }
    if(maxx < summary)
    {
        maxx = summary;
        index_i = i;
    }
    Console.WriteLine($"  {i} chi ustundagi raqamlar yig'indisi >> {summary}.\n\n");
}

Console.WriteLine($"Eng kotta yig'indi >> {maxx}.\n");
for(int i = 0; i < number; i++)
{
    Console.Write("  ");
    Console.WriteLine(arr[i, index_i]);
    
}
Console.WriteLine();
Console.WriteLine();

for(int i = 0; i < number; i++)
{
    for(int j = 0; j < number; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

var maxx1 = arr[0, 0];
var mini = arr[0, 0];
var index_i1 = 0;
var index_j1 = 0;
var index_i2 = 0;
var index_j2 = 0;

for(int i = 0; i < number; i++)
{
    for(int j = 0; j < number; j++)
    {
        if(maxx1 < arr[i, j])
        {
            maxx1 = arr[i, j];
            index_i1 = i;
            index_j1 = j;
        }
        if(mini > arr[i, j])
        {
            mini = arr[i, j];
            index_i2 = i;
            index_j2 = j;
        }
    }
}
Console.WriteLine("  Eng kotta son >> " + maxx1);
Console.WriteLine("  Eng kotta sonning satr bo'yicha joylashgan o'rni >> " + index_i1);
Console.WriteLine("  Eng kotta sonning ustun bo'yicha joylashgan o'rni >> " + index_j1);
Console.WriteLine();
Console.WriteLine("  Eng kichik son >> " + mini);
Console.WriteLine("  Eng kichik sonning satr bo'yicha joylashgan o'rni >> " + index_i2);
Console.WriteLine("  Eng kichik sonning ustun bo'yicha joylashgan o'rni >> " + index_j2);
Console.WriteLine();

var helperMax = arr[index_i1, index_j1];
arr[index_i1, index_j1] = arr[number - 1, number - 1];
arr[number - 1, number - 1] = helperMax;

var helperMin = arr[index_i2, index_j2];
arr[index_i2, index_j2] = arr[0, 0];
arr[0, 0] = helperMin;


for(int i = 0; i < number; i++)
{
    for(int j = 0; j < number; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(); 
Console.WriteLine();
