using System;
public class Logic
{
    //логика программы в которой происходит поиск ответа на поставленную задачу с текущими данными
    public static Double solution(double x)
    { 
        //проверка принадлежности числда х 1 из диапазонов
        if (x <= 0) return 0; 
        else if (0 < x && x <= 1) return x;
        else return x * x;
    }
}
    class Program
{
    static void Main()
    {
        try //обработка ошибки, при неверно введённом формате данных
        {
            //основная часть программы в которой происходит ввод данных и вывод ответа.
            Console.WriteLine("Введите число:");
            Double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ответ:");
            var output = Logic.solution(x);
            Console.WriteLine(output); 
        }
        catch (FormatException) { Console.WriteLine("формат введённых данных некорректен, попробуйте ещё раз"); }
    }
}
