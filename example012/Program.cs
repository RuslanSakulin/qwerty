// Виды методов:
// Вид 1:
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
*/

// Вид 2:
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
} 
Method2(msg: "Текст сообщения");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
Method21(count: 4, msg: "Новый текст");
*/

//Вид 3:
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
//Вид 4:
/*
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty; // result = "";

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(5, " asd ");
Console.WriteLine(res);
*/
//Вид 4 через for:
/*
string Method4(int count, string c)
{
    string result = String.Empty; // result = "";
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(5, " asd ");
Console.WriteLine(res);
*/
//Вывод таблицы умножения на экран: (!цикл в цикле!)
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/
//Дан текст. В тексте нужно все пробелы заменить
//черточками, маленькие буквы "к" заменить большими
//буквами "К", а большие "С" заменить маленькими "с".
/*
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы Вы дадите мне чаю?";

// sting s = "qwerty"
//            012345 
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText); // первый вызов метода
Console.WriteLine(); //чтобы разделять вывод на экране
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText); //второй вызов метода
Console.WriteLine();
newText = Replace(newText, '-', '+');
Console.WriteLine(newText); //третий вызов метода
*/

// Упорядочивание массива от меньшего к большему:
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
*/
// Упорядочивание массива от большего к меньшему:
/*
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);
*/