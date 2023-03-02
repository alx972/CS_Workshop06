// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int graph1 = 0;
const int graph2 = 1;

double InputNumber(string message) // ввод с клавиатуры
{
    Console.Write($"{message} > ");
    double value;
    if (double.TryParse(Console.ReadLine(), out value)) // проверка правильности ввода числа
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1); // exit code программы при ошибке
    return 0; // функция возвращает 0, потому что надо что-то возвращать int
}

bool ValidateGraphs((double k, double b)[] graph) // проверка на пересечение
{
    if (graph[graph1].k == graph[graph2].k)
    {
        return false;
    }
    else
    {
        return true;
    }
}

// метод находит точку пересечения графиков. возвращает кортеж значений
(double intersectX, double intersectY) GraphsIntersect((double k, double b)[] graph)
{
    double intersectX = (graph[graph2].b - graph[graph1].b) / (graph[graph1].k - graph[graph2].k);
    double intersectY = graph[graph1].k*intersectX + graph[graph1].b;
    return (intersectX, intersectY);
}

Console.WriteLine("Введите коэффициенты для двух графиков вида y = kx + b");
// для коэффициентов используем массив кортежей
(double k, double b)[] graph = new[] {(InputNumber($"k1"),InputNumber($"b1")), 
                                (InputNumber($"k2"),InputNumber($"b2"))};

if (ValidateGraphs(graph))
{
    Console.WriteLine("Точка пересечения для графиков ");
    Console.WriteLine($"y = {graph[graph1].k:f2}x + {graph[graph1].b:f2}");
    Console.WriteLine($"y = {graph[graph2].k:f2}x + {graph[graph2].b:f2}");
    Console.WriteLine(GraphsIntersect(graph));
}
else
{
    Console.WriteLine("Графики не пересекаются или совпадают");
}