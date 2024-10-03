try
{
    Console.WriteLine("Добро пожаловать это простая задача для нахождения частоты)");
    Console.WriteLine("Введите первую переменную С:");
    double C = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите вторую переменную L:");
    double L = double.Parse(Console.ReadLine());
    Console.WriteLine("Сначало находим T");
    double T = 2 * Math.PI * Math.Sqrt(C * L);
    Console.WriteLine("T = " + T);
    Console.WriteLine("Теперь найдем частоту");
    double V = 1 / T;
    Console.WriteLine(" и наша частота(V) = " + V);
}

catch
{
    Console.WriteLine("эх эх не правильно вел значения....");
}
