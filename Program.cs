//Создайте интерфейс IResizable с методами Resize(double factor) и GetSize(). Затем создайте класс ResizableArray, который реализует этот интерфейс
//    и использует массив для хранения элементов. Напишите программу, которая позволяет изменять размер массива и получать текущий размер.

//Требования:

//Интерфейс IResizable должен содержать методы void Resize(double factor) и int GetSize().
//Класс ResizableArray должен реализовывать интерфейс IResizable и использовать массив для хранения элементов.
//В классе ResizableArray метод Resize должен изменять размер массива пропорционально переданному фактору
//    (например, если фактор равен 2, размер массива должен удвоиться).
//Метод GetSize должен возвращать текущий размер массива.
//Программа должна создавать объект класса ResizableArray, изменять его размер с помощью метода Resize и выводить текущий размер с помощью метода GetSize.


var Array = new ResizableArray(6);
Array.PrintArray();
Array.FillingTheArray();
Array.PrintArray();
Console.WriteLine($"Size of mas: {Array.GetSize()}");
Array.Resize(2);
Array.PrintArray();
Array.FillingTheArray();
Array.PrintArray();
Console.WriteLine($"New size of mas: {Array.GetSize()}");
Console.WriteLine("--------------------------------------------");

Array.Resize(0.25);
Array.PrintArray();
Console.WriteLine($"New size of mas: {Array.GetSize()}");
Console.WriteLine("--------------------------------------------");

Array.Resize(-3);
Array.PrintArray();
Console.WriteLine($"New size of mas: {Array.GetSize()}");
interface IResizable
{
    void Resize(double factor);
    int GetSize();
}

class ResizableArray : IResizable
{

    public int SizeX { get;private set; }
    public int[] mas;
    public ResizableArray(int sizeX)
    {
        SizeX = sizeX;
        mas = new int[sizeX];
    }
    public void FillingTheArray()
    { 
    for (int i = 0; i < SizeX; i++)
    {
        mas[i] = i + 1;
    }
    }
    public void Resize(double factor)
    {
        if (factor <= 0)
            Console.WriteLine("размер массива не может быть отрицательным");
       
        else
        {
            int newSizeX = (int)(SizeX * factor);
            var newMas = new int[newSizeX];
            if (newSizeX > SizeX)
            {
                for (int i = 0; i < SizeX; i++)
                {
                    newMas[i] = mas[i];
                }
            }
            else
            {
                for (int i = 0; i < newSizeX; i++)
                {
                    newMas[i] = mas[i];
                }
            }
            mas = newMas;
            SizeX = newSizeX;
        }
    }

    public int GetSize()
    {
        return SizeX;
    }

    public void PrintArray()
    {
        for (int i = 0; i < SizeX; i++)
        {
            Console.Write($"{mas[i]}\t");
        }
        Console.WriteLine();
    }
}