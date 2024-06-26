using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Модуль расчета стоимости монтажа теплого пола");

        double area = InputHelper.GetAreaInput();
        double costPerSquareMeter = InputHelper.GetCostPerSquareMeterInput();

        double totalCost = CalculationHelper.CalculateTotalCost(area, costPerSquareMeter);

        OutputHelper.DisplayTotalCost(totalCost);

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

class InputHelper
{
    public static double GetDoubleInput(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

    public static double GetAreaInput()
    {
        return GetDoubleInput("Введите площадь помещения в квадратных метрах: ");
    }

    public static double GetCostPerSquareMeterInput()
    {
        return GetDoubleInput("Введите стоимость монтажа за квадратный метр: ");
    }
}

class CalculationHelper
{
    public static double CalculateTotalCost(double area, double costPerSquareMeter)
    {
        return area * costPerSquareMeter;
    }
}

class OutputHelper
{
    public static void DisplayTotalCost(double totalCost)
    {
        Console.WriteLine($"Общая стоимость монтажа теплого пола: {totalCost} рублей");
    }
}
