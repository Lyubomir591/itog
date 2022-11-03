// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа 
// создать массив из строк, в который попадут только символы, не являющиеця цифрами.
// Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных. 
// При решении не использовать "читерство".
char[] Method(int nuber)
{
    char[] arrayChar = {
        'q', 'w', 'e', 'r', 't', 'y',
        'u', 'i', 'o', 'p', 'a', 's',
        'd', 'f', 'g', 'h', 'j', 'k',
        'l', 'z', 'x', 'c', 'v', 'b',
        'n', 'm', '1', '2', '3', '4',
        '5', '6', '7', '8', '9', '0'
    };
    char[] array = new char[nuber];
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        int number = new Random().Next(0, arrayChar.Length);
        array[i] = arrayChar[number];
    }
    return array;
}
char[] arraycd = Method(15);
for (int j = 0; j < arraycd.Length; j++)
{
    Console.WriteLine(arraycd[j]);
};

var numbers = String.Empty;
var alfavit = String.Empty;
foreach (var item in arraycd)
{
    if (char.IsDigit(item))
    {
        numbers += item;

    }
    if (!char.IsDigit(item))
    {
        alfavit += item;
    }

}
Console.WriteLine(numbers);
Console.WriteLine(alfavit);

