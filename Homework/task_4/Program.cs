//Напишите программу, которая принимает на вход три числа и 
//выдает максимальное из этих чисел
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22
class MaxThreeNumbers {
    public static void Main(string [] args) {
        try {
            // Выводим строку
            Console.WriteLine("Введите три числа через запятую");
            // Читаем введенную строку с запятыми, считая что там всего три значения через запятую
            string input = Console.ReadLine();
            // Делим строку на части в том месте, где стоят запятые
            string[] parts = input.Split(",");
            // Превращаем три значения из строк в числа
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            int c = int.Parse(parts[2]);
            // Находим максимум из первого и максимума второго и третьего
            int max = Math.Max(a, Math.Max(b, c));
            // Выводим его в терминал
            Console.WriteLine("Максимум из введенных чисел: " + max);
        } catch (Exception ex) {
            // А тут мы окажемся, если выше случится какое то говно
            Console.WriteLine(ex.Message);
        }
    }
}

// int a = Console.ReadLine();
// max = a;
// if (b > a)
//     max = b;
// if (c > max)
//     max = c;