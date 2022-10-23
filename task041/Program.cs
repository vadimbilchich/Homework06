// Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write(" Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for(int i = 0; i < numbers.Length; i ++)
{
    if(numbers[i] > 0)
    {
        sum ++;
    }
}
Console.WriteLine();
Console.WriteLine($" Количество значений больше 0 = {sum}");

int[] StringToNum(string input)
{
    int count = 1;
    for(int i = 0; i < input.Length; i ++)
    {
        if(inp[i] == ',')
        {
            count ++;
        }
    }
}
int[] numbers = new int[count];
int index = 0;

for(int i = 0; i < inp.Length; i ++)
{
    string temp = "";
    while(inp[i] != ',')
    {
        if(i != inp.Length - 1)
        {
            temp += inp[i].ToString();
            i ++;
        }
        else
        {
            temp += inp[i].ToString();
            break;
        }
        numbers[index] = Convert.ToInt32(temp);
        index ++;
    }
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}