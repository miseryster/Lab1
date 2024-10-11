using System;

public class Program
{
    // Метод для получения дробной части числа
    public double fraction(double x)
    {
        return x - (int)x; // Возвращаем дробную часть, вычитая целую часть из числа
    }

    // Метод для преобразования символа в соответствующее числовое значение
    public int charToNum(char x)
    {
        return x - '0'; // Преобразуем символ в число, вычитая '0'
    }

    // Метод для проверки, является ли число двузначным
    public bool is2Digits(int x)
    {
        return x >= 10 && x <= 99; // Проверяем, двузначное ли число
    }

    // Метод для проверки, находится ли число в заданном диапазоне
    public bool isInRange(int a, int b, int num)
    {
        int min = a < b ? a : b; // Определяем минимальное значение
        int max = a > b ? a : b; // Определяем максимальное значение
        return num >= min && num <= max; // Проверяем, входит ли num в диапазон
    }

    // Метод для проверки равенства трех чисел
    public bool isEqual(int a, int b, int c)
    {
        return a == b && b == c; // Проверяем, равны ли все три числа
    }

    // Метод для получения абсолютного значения числа
    public int abs(int x)
    {
        return x < 0 ? -x : x; // Возвращаем модуль числа (положительное значение)
    }

    // Метод для проверки, делится ли число на 3 или 5 (но не на оба)
    public bool is35(int x)
    {
        return (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0); // Проверяем условия
    }

    // Метод для нахождения максимального из трех чисел
    public int max3(int x, int y, int z)
    {
        int max = x; // Предполагаем, что x - максимум
        if (y > max) max = y; // Сравниваем с y
        if (z > max) max = z; // Сравниваем с z
        return max; // Возвращаем максимум из трех чисел
    }

    // Метод для нахождения суммы двух чисел с проверкой диапазона
    public int sum2(int x, int y)
    {
        int sum = x + y; // Суммируем два числа
        return sum >= 10 && sum <= 19 ? 20 : sum; // Проверяем диапазон
    }

    // Метод для получения названия дня недели по номеру
    public string day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник"; // Если 1, возвращаем "понедельник"
            case 2: return "вторник"; // Если 2, возвращаем "вторник"
            case 3: return "среда"; // Если 3, возвращаем "среда"
            case 4: return "четверг"; // Если 4, возвращаем "четверг"
            case 5: return "пятница"; // Если 5, возвращаем "пятница"
            case 6: return "суббота"; // Если 6, возвращаем "суббота"
            case 7: return "воскресенье"; // Если 7, возвращаем "воскресенье"
            default: return "это не день недели"; // Если некорректный ввод, возвращаем сообщение
        }
    }

    // Метод для создания списка чисел от 0 до x
    public string listNums(int x)
    {
        string result = ""; // Инициализируем пустую строку для результата
        for (int i = 0; i <= x; i++)
        {
            result += i + " "; // Собираем строку с числами
        }
        return result.Trim(); // Возвращаем строку, убирая лишний пробел
    }

    // Метод для создания списка четных чисел от 0 до x
    public string chet(int x)
    {
        string result = ""; // Инициализируем пустую строку для результата
        for (int i = 0; i <= x; i += 2)
        {
            result += i + " "; // Собираем строку с четными числами
        }
        return result.Trim(); // Возвращаем строку, убирая лишний пробел
    }

    // Метод для подсчета длины числа
    public int numLen(long x)
    {
        int count = 0; // Счетчик цифр
        while (x != 0)
        {
            x /= 10; // Уменьшаем число
            count++; // Увеличиваем счетчик
        }
        return count; // Возвращаем длину числа
    }

    // Метод для рисования квадрата из символов '*'
    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(new string('*', x)); // Выводим квадрат
        }
    }

    // Метод для рисования правого треугольника из символов '*'
    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine(new string(' ', x - i) + new string('*', i)); // Выводим правый треугольник
        }
    }

    // Метод для поиска первого вхождения элемента в массив
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i; // Возвращаем индекс первого вхождения
        }
        return -1; // Если не найдено, возвращаем -1
    }

    // Метод для нахождения максимального по модулю элемента в массиве
    public int maxAbs(int[] arr)
    {
        int maxAbsValue = arr[0]; // Инициализируем максимальное значение первым элементом
        for (int i = 1; i < arr.Length; i++)
        {
            // Если текущее значение по модулю больше максимального, обновляем максимум
            if (abs(arr[i]) > abs(maxAbsValue))
            {
                maxAbsValue = arr[i];
            }
        }
        return maxAbsValue; // Возвращаем наибольшее по модулю значение
    }

    // Метод для добавления одного массива в другой по заданной позиции
    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length]; // Создаем новый массив
        Array.Copy(arr, 0, result, 0, pos); // Копируем элементы до pos
        Array.Copy(ins, 0, result, pos, ins.Length); // Вставляем ins
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos); // Копируем оставшиеся элементы
        return result; // Возвращаем новый массив
    }

    // Метод для реверса массива
    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length]; // Создаем новый массив
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i]; // Заполняем массив в обратном порядке
        }
        return result; // Возвращаем новый массив
    }

    // Метод для поиска всех вхождений элемента в массиве
    public int[] findAll(int[] arr, int x)
    {
        int count = 0; // Счетчик для количества вхождений
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++; // Считаем количество вхождений
        }

        int[] result = new int[count]; // Создаем новый массив нужного размера
        count = 0; // Сбрасываем счетчик для записи индексов
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[count++] = i; // Заполняем массив индексами
            }
        }
        return result; // Возвращаем новый массив с индексами
    }

    // Метод для проверки входных данных в зависимости от выбора метода
    // Метод для проверки входных данных
    public bool ValidateInput(int choice)
    {
        // Используем switch для обработки различных методов в зависимости от выбора пользователя
        switch (choice)
        {
            case 1: // Проверка дробной части
                Console.Write("Введите число (double) для дробной части: "); // Запрашиваем у пользователя ввод числа
                                                                             // Пытаемся преобразовать введенную строку в double
                if (double.TryParse(Console.ReadLine(), out double dValue))
                {
                    // Если преобразование успешно, вызываем метод fraction и выводим результат
                    Console.WriteLine($"Дробная часть: {fraction(dValue)}");
                    return true; // Возвращаем true, если ввод успешен
                }
                break; // Переходим к следующему случаю, если преобразование не удалось

            case 2: // Преобразование символа в число
                Console.Write("Введите символ (0-9): "); // Запрашиваем у пользователя ввод символа
                                                         // Пытаемся преобразовать строку в char и проверяем, попадает ли он в диапазон '0'-'9'
                if (char.TryParse(Console.ReadLine(), out char cValue) && cValue >= '0' && cValue <= '9')
                {
                    // Если ввод успешен, вызываем метод charToNum и выводим результат
                    Console.WriteLine($"Число: {charToNum(cValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 3: // Проверка на двузначное число
                Console.Write("Введите число (int): "); // Запрашиваем ввод числа
                                                        // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int iValue))
                {
                    // Если ввод успешен, вызываем метод is2Digits и выводим результат
                    Console.WriteLine($"Двузначное: {is2Digits(iValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 4: // Проверка на вхождение в диапазон
                int aValue; // Переменные для границ диапазона
                int bValue;
                int numValue; // Переменная для проверяемого числа
                Console.Write("Введите левую границу (int): "); // Запрашиваем левую границу
                                                                // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out aValue))
                {
                    Console.Write("Введите правую границу (int): "); // Запрашиваем правую границу
                                                                     // Пытаемся преобразовать строку в int
                    if (int.TryParse(Console.ReadLine(), out bValue))
                    {
                        Console.Write("Введите число (int): "); // Запрашиваем число для проверки
                                                                // Пытаемся преобразовать строку в int
                        if (int.TryParse(Console.ReadLine(), out numValue))
                        {
                            // Если все преобразования успешны, вызываем метод isInRange и выводим результат
                            Console.WriteLine($"Входит в диапазон: {isInRange(aValue, bValue, numValue)}");
                            return true; // Успешная валидация
                        }
                    }
                }
                break;

            case 5: // Проверка на равенство трех чисел
                Console.Write("Введите три числа, каждое с новой строки (int): "); // Запрашиваем три числа
                                                            // Пытаемся преобразовать строки в int
                if (int.TryParse(Console.ReadLine(), out int a) &&
                    int.TryParse(Console.ReadLine(), out int b) &&
                    int.TryParse(Console.ReadLine(), out int c))
                {
                    // Если все преобразования успешны, вызываем метод isEqual и выводим результат
                    Console.WriteLine($"Все числа равны: {isEqual(a, b, c)}");
                    return true; // Успешная валидация
                }
                break;

            case 6: // Проверка модуля числа
                Console.Write("Введите число (int): "); // Запрашиваем число
                                                        // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int absValue))
                {
                    // Если ввод успешен, вызываем метод abs и выводим результат
                    Console.WriteLine($"Модуль: {abs(absValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 7: // Проверка делимости на 3 или 5
                Console.Write("Введите число (int): "); // Запрашиваем число
                                                        // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int checkValue))
                {
                    // Если ввод успешен, вызываем метод is35 и выводим результат
                    Console.WriteLine($"Делится на 3 или 5: {is35(checkValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 8: // Поиск максимума среди трех чисел
                Console.Write("Введите три числа, каждое с новой строки (int): "); // Запрашиваем три числа
                                                            // Пытаемся преобразовать строки в int
                if (int.TryParse(Console.ReadLine(), out int x) &&
                    int.TryParse(Console.ReadLine(), out int y) &&
                    int.TryParse(Console.ReadLine(), out int z))
                {
                    // Если все преобразования успешны, вызываем метод max3 и выводим результат
                    Console.WriteLine($"Максимум: {max3(x, y, z)}");
                    return true; // Успешная валидация
                }
                break;

            case 9: // Сложение двух чисел
                Console.Write("Введите два числа, каждое с новой строки (int): "); // Запрашиваем два числа
                                                            // Пытаемся преобразовать строки в int
                if (int.TryParse(Console.ReadLine(), out int xValue) &&
                    int.TryParse(Console.ReadLine(), out int yValue))
                {
                    // Если оба ввода успешны, вызываем метод sum2 и выводим результат
                    Console.WriteLine($"Сумма: {sum2(xValue, yValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 10: // Получение дня недели по номеру
                Console.Write("Введите день недели (1-7): "); // Запрашиваем номер дня недели
                                                              // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int dayValue))
                {
                    // Если ввод успешен, вызываем метод day и выводим результат
                    Console.WriteLine(day(dayValue));
                    return true; // Успешная валидация
                }
                break;

            case 11: // Вывод списка чисел от 1 до n
                Console.Write("Введите число (int): "); // Запрашиваем число
                                                        // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int numCount))
                {
                    // Если ввод успешен, вызываем метод listNums и выводим результат
                    Console.WriteLine(listNums(numCount));
                    return true; // Успешная валидация
                }
                break;

            case 12: // Вывод четных чисел до n
                Console.Write("Введите число (int): "); // Запрашиваем число
                                                        // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int chetCount))
                {
                    // Если ввод успешен, вызываем метод chet и выводим результат
                    Console.WriteLine(chet(chetCount));
                    return true; // Успешная валидация
                }
                break;

            case 13: // Получение длины числа
                Console.Write("Введите число (long): "); // Запрашиваем длинное число
                                                         // Пытаемся преобразовать строку в long
                if (long.TryParse(Console.ReadLine(), out long lengthValue))
                {
                    // Если ввод успешен, вызываем метод numLen и выводим результат
                    Console.WriteLine($"Длина числа: {numLen(lengthValue)}");
                    return true; // Успешная валидация
                }
                break;

            case 14: // Рисование квадрата
                Console.Write("Введите размер квадрата (int): "); // Запрашиваем размер квадрата
                                                                  // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int squareSize))
                {
                    // Если ввод успешен, вызываем метод square для рисования квадрата
                    square(squareSize);
                    return true; // Успешная валидация
                }
                break;

            case 15: // Рисование прямоугольного треугольника
                Console.Write("Введите размер треугольника (int): "); // Запрашиваем размер треугольника
                                                                      // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int triangleSize))
                {
                    // Если ввод успешен, вызываем метод rightTriangle для рисования треугольника
                    rightTriangle(triangleSize);
                    return true; // Успешная валидация
                }
                break;

            case 16: // Поиск первого вхождения числа в массив
                Console.Write("Введите размер массива (int): "); // Запрашиваем размер массива
                                                                 // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int arrSize))
                {
                    int[] arr = new int[arrSize]; // Создаем массив заданного размера
                    Console.WriteLine("Введите элементы массива: "); // Запрашиваем элементы массива
                                                                     // Заполняем массив, считывая элементы от пользователя
                    for (int i = 0; i < arrSize; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите число для поиска: "); // Запрашиваем число для поиска
                                                                 // Пытаемся преобразовать строку в int
                    if (int.TryParse(Console.ReadLine(), out int searchValue))
                    {
                        // Если ввод успешен, вызываем метод findFirst и выводим результат
                        Console.WriteLine($"Индекс: {findFirst(arr, searchValue)}");
                        return true; // Успешная валидация
                    }
                }
                break;

            case 17: // Поиск максимального по модулю элемента в массиве
                Console.Write("Введите размер массива (int): "); // Запрашиваем размер массива
                                                                 // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int maxArrSize))
                {
                    int[] arr = new int[maxArrSize]; // Создаем массив заданного размера
                    Console.WriteLine("Введите элементы массива: "); // Запрашиваем элементы массива
                                                                     // Заполняем массив, считывая элементы от пользователя
                    for (int i = 0; i < maxArrSize; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    // Если ввод успешен, вызываем метод maxAbs и выводим результат
                    Console.WriteLine($"Максимальное по модулю: {maxAbs(arr)}");
                    return true; // Успешная валидация
                }
                break;

            case 18: // Вставка одного массива в другой
                Console.Write("Введите размер первого массива (int): "); // Запрашиваем размер первого массива
                                                                         // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int firstArrSize))
                {
                    int[] arr = new int[firstArrSize]; // Создаем первый массив
                    Console.WriteLine("Введите элементы первого массива: "); // Запрашиваем элементы первого массива
                                                                             // Заполняем массив, считывая элементы от пользователя
                    for (int i = 0; i < firstArrSize; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите размер второго массива (int): "); // Запрашиваем размер второго массива
                                                                             // Пытаемся преобразовать строку в int
                    if (int.TryParse(Console.ReadLine(), out int insArrSize))
                    {
                        int[] ins = new int[insArrSize]; // Создаем второй массив
                        Console.WriteLine("Введите элементы второго массива: "); // Запрашиваем элементы второго массива
                                                                                 // Заполняем массив, считывая элементы от пользователя
                        for (int i = 0; i < insArrSize; i++)
                        {
                            ins[i] = int.Parse(Console.ReadLine());
                        }

                        Console.Write("Введите позицию вставки (int): "); // Запрашиваем позицию вставки
                                                                          // Пытаемся преобразовать строку в int
                        if (int.TryParse(Console.ReadLine(), out int posValue))
                        {
                            // Если все вводы успешны, вызываем метод add и выводим результат
                            int[] result = add(arr, ins, posValue);
                            Console.WriteLine($"Результат: {string.Join(", ", result)}");
                            return true; // Успешная валидация
                        }
                    }
                }
                break;

            case 19: // Реверс массива
                Console.Write("Введите размер массива (int): "); // Запрашиваем размер массива
                                                                 // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int reverseArrSize))
                {
                    int[] arr = new int[reverseArrSize]; // Создаем массив заданного размера
                    Console.WriteLine("Введите элементы массива: "); // Запрашиваем элементы массива
                                                                     // Заполняем массив, считывая элементы от пользователя
                    for (int i = 0; i < reverseArrSize; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    // Если ввод успешен, вызываем метод reverseBack и выводим результат
                    int[] reversed = reverseBack(arr);
                    Console.WriteLine($"Обратный массив: {string.Join(", ", reversed)}");
                    return true; // Успешная валидация
                }
                break;

            case 20: // Поиск всех индексов заданного числа в массиве
                Console.Write("Введите размер массива (int): "); // Запрашиваем размер массива
                                                                 // Пытаемся преобразовать строку в int
                if (int.TryParse(Console.ReadLine(), out int findAllSize))
                {
                    int[] arr = new int[findAllSize]; // Создаем массив заданного размера
                    Console.WriteLine("Введите элементы массива: "); // Запрашиваем элементы массива
                                                                     // Заполняем массив, считывая элементы от пользователя
                    for (int i = 0; i < findAllSize; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Введите число для поиска: "); // Запрашиваем число для поиска
                                                                 // Пытаемся преобразовать строку в int
                    if (int.TryParse(Console.ReadLine(), out int findAllValue))
                    {
                        // Если ввод успешен, вызываем метод findAll и выводим результат
                        int[] foundIndexes = findAll(arr, findAllValue);
                        Console.WriteLine($"Индексы: {string.Join(", ", foundIndexes)}");
                        return true; // Успешная валидация
                    }
                }
                break;
        }

        // Если ни один из случаев не прошел валидацию, выводим сообщение об ошибке
        Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
        return false; // Возвращаем false, если ввод некорректен
    }

    // Главный метод, который будет выполнять программу
    public static void Main(string[] args)
    {
        Program program = new Program();// Создаем экземпляр программы
         // Бесконечный цикл для повторного запроса выбора
        while (true)
        {
            Console.WriteLine("Выберите метод:");
            Console.WriteLine("1. Дробная часть числа");
            Console.WriteLine("2. Символ в число");
            Console.WriteLine("3. Двузначное число");
            Console.WriteLine("4. Проверка диапазона");
            Console.WriteLine("5. Проверка равенства");
            Console.WriteLine("6. Модуль числа");
            Console.WriteLine("7. Делимость на 3 или 5");
            Console.WriteLine("8. Максимум из трех чисел");
            Console.WriteLine("9. Сумма чисел");
            Console.WriteLine("10. День недели");
            Console.WriteLine("11. Список чисел");
            Console.WriteLine("12. Четные числа");
            Console.WriteLine("13. Длина числа");
            Console.WriteLine("14. Квадрат из символов");
            Console.WriteLine("15. Правый треугольник");
            Console.WriteLine("16. Поиск первого вхождения");
            Console.WriteLine("17. Поиск максимального по модулю");
            Console.WriteLine("18. Добавление массива");
            Console.WriteLine("19. Реверс массива");
            Console.WriteLine("20. Все вхождения");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 20)
            {// Проверяем входные данные и выполняем соответствующий метод
                if (!program.ValidateInput(choice))
                {
                    Console.WriteLine("Пожалуйста, повторите ввод.");// Запрашиваем повтор
                }
            }
            else
            {
                Console.WriteLine("Некорректный выбор. Пожалуйста, выберите число от 1 до 20.");// Ошибка ввода
            }
        }
    }
}
