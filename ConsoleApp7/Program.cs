int[] numbers = { -1,-2,-3,-4,0,5,6,7,8,9};
var r1 = numbers.Where(s =>s<=0).ToList();
foreach (var item in r1)
{
    Console.WriteLine(item);
}
var r2 = numbers.Where(s => s > 0);
foreach (var item in r2)
{
    Console.WriteLine(item);
}