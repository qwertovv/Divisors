namespace ClassLibraryDeliteli
{
    /// <summary>
    /// Решение задачи Делители
    /// </summary>
    public static class Deliteli
    {
        /// <summary>
        /// Задание 1: Поиск всех делителей числа n
        /// </summary>
        /// <param name="n">заданное число</param>
        /// <returns>Все делители заданного числа n</returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<int> FindAllDivisors(int n)
        {
            if (n == 0)
            {
                throw new ArgumentException("Ноль не имеет делителей");
            }
            List<int> divisiors = new List<int>();

            divisiors.Add(1); // Добавляем единицу к делителям
            if (n != 1)
            {
                divisiors.Add(n); // Если число не равно единице, добавляем его в делители
            }

            FindOtherDivisiors(n, divisiors); // Поиск остальных делителй (кроме 0 и n)
            divisiors.Sort(); // Сортировка делителей по возрастанию
            return divisiors;
        }
        /// <summary>
        /// Поиск делителей кроме 0 и 1
        /// </summary>
        /// <param name="n">заданное число n</param>
        /// <param name="divisiors">список делителей, состоящий из 0 и 1</param>
        public static void FindOtherDivisiors(int n, List<int> divisiors)
        {
            for (int i = 2; i <= n/2; i++) // перебираем числа от 2 до n/2
            {
                if (n % i == 0)
                {
                    if(!divisiors.Contains(i))
                    {
                        divisiors.Add(i);
                    }

                }
            }
        }
        /// <summary>
        /// Вывод всех делителей числа n
        /// </summary>
        /// <param name="n">заданное число</param>
        /// <returns>строка, в которой перечислены все делители числа n через запятую</returns>
        public static string PrintDivisiors(int n)
        {
            try
            {
                List<int> divisiors = FindAllDivisors(n);
                return string.Join(",", divisiors);
            }
            catch (Exception)
            {
                return "Ошибка";
            }
        }
        /// <summary>
        /// Поиск чисел с 5 делителями на отрезке
        /// </summary>
        /// <param name="m">начало отрезка</param>
        /// <param name="n">конец отрезка</param>
        /// <returns>список чисел с 5 делителями на отрезке</returns>
        public static List<int> FindNumbersWith5Divisors(int m, int n)
        {
            List<int> result = new List<int>(); // инициализация списка

            for (int num = m; num <= n; num++) // перебор чисел на отрезке
            {
                if (HasExactly5Divisors(num)) // если у числа ровно 5 делителей, добавляем в список
                {
                    result.Add(num);
                }
            }

            return result;
        }
        /// <summary>
        /// Ровно ли пять делителей у числа
        /// </summary>
        /// <param name="num">число из отрезка</param>
        /// <returns>истина, если число имеет ровно 5 делителей, иначе - ложь</returns>
        public static bool HasExactly5Divisors(int num)
        {
            // Число имеет ровно 5 делителей только если оно является p^4, где p - простое
            // (так как количество делителей = (4+1) = 5)
            return IsPrimePower(num, 4);
        }
        /// <summary>
        /// Является ли число степенью простого числа с заданной степенью
        /// </summary>
        /// <param name="num">число</param>
        /// <param name="power">степень</param>
        /// <returns>истина, если число является степенью простого числа, иначе ложь</returns>
        public static bool IsPrimePower(int num, int power)
        {
            if (num < 2) return false;

            // Находим возможное простое основание
            int primeBase = FindPrimeBase(num, power);

            return primeBase != -1 && Math.Pow(primeBase, power) == num;
        }
        /// <summary>
        /// Поиск простого основания, если число является степенью простого числа
        /// </summary>
        /// <param name="num">число</param>
        /// <param name="power">степень</param>
        /// <returns>простое основание</returns>
        public static int FindPrimeBase(int num, int power)
        {
            // Проверяем возможные основания до корня степени из num
            int maxPossibleBase = (int)Math.Pow(num, 1.0 / power);

            for (int baseNum = 2; baseNum <= maxPossibleBase; baseNum++)
            {
                if (IsPrime(baseNum) && Math.Pow(baseNum, power) == num) // если основание простое число и в степени оно является нужным число
                {
                    return baseNum;
                }
            }

            return -1;
        }
        /// <summary>
        /// Является ли число простым
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>истина, если простое, иначе ложь</returns>
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        /// <summary>
        /// Вывод чисел с 5 делителями
        /// </summary>
        /// <param name="m">начало отрезка</param>
        /// <param name="n">конец отрезка</param>
        public static string PrintNumbersWith5Divisors(int m, int n)
        {
            List<int> numbers = FindNumbersWith5Divisors(m, n);

            if (numbers.Count == 0)
            {
                return $"Чисел, имеющих ровно 5 делителей не найдено в диапазоне [{m}, {n}]";
            }
            else
            {
                return $"Числа ровно с 5 делителями в диапазоне [{m}, {n}]: {string.Join(", ", numbers)}";
            }
        }
        /// <summary>
        /// Словарь с факторизованным числом
        /// </summary>
        /// <param name="n">заданное число</param>
        /// <returns>Словарь с факторизованным числом</returns>
        /// <exception cref="ArgumentException"></exception>
        public static Dictionary<int, int> Factorize(int n)
        {
            if (n <= 1)
                throw new ArgumentException("Число должно быть больше 1");

            Dictionary<int, int> factors = new Dictionary<int, int>();
            int remaining = n;

            // Обрабатываем делитель 2 отдельно
            remaining = ProcessFactor(remaining, 2, factors);

            // Проверяем нечетные делители от 3 до sqrt(n)
            for (int i = 3; i <= Math.Sqrt(remaining); i += 2)
            {
                remaining = ProcessFactor(remaining, i, factors);
            }

            // Если оставшееся число больше 1, оно само простое
            if (remaining > 1)
            {
                AddFactor(factors, remaining);
            }

            return factors;
        }
        /// <summary>
        /// Обработка делителя
        /// </summary>
        /// <param name="number">число</param>
        /// <param name="divisor">делитель</param>
        /// <param name="factors">словарь с факторизацией</param>
        /// <returns>число</returns>
        public static int ProcessFactor(int number, int divisor, Dictionary<int, int> factors)
        {
            while (number % divisor == 0)
            {
                AddFactor(factors, divisor);
                number /= divisor;
            }
            return number;
        }
        /// <summary>
        /// Добавление числа в факторизованный список
        /// </summary>
        /// <param name="factors">список факторизованных чисел</param>
        /// <param name="factor">факторизованное число (элемент)</param>
        public static void AddFactor(Dictionary<int, int> factors, int factor)
        {
            if (factors.ContainsKey(factor))
                factors[factor]++;
            else
                factors[factor] = 1;
        } 
        /// <summary>
        /// Вывод факторизованного числа
        /// </summary>
        /// <param name="n">заданное число</param>
        /// <returns>факторизованное число</returns>
        public static string GetFactorizationString(int n)
        {

            var factors = Factorize(n);
            List<string> parts = new List<string>();

            foreach (var factor in factors)
            {
                if (factor.Value == 1)
                    parts.Add($"{factor.Key}");
                else
                    parts.Add($"{factor.Key}^{factor.Value}");
            }
            return $"{n} = {string.Join(" * ", parts)}";
            
        }
        /// <summary>
        /// Основной метод, возвращающий список из первых N простых чисел
        /// </summary>
        /// <param name="n">количество чисел</param>
        /// <returns>список простых чисел</returns>
        /// <exception cref="ArgumentException"></exception>
        public static List<int> GenerateFirstNPrimes(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Количество чисел должно быть положительным");

            List<int> primes = new List<int>();

            if (n >= 1) primes.Add(2); // Первое простое число
            if (n >= 2) primes.Add(3); // Второе простое число

            int candidate = 5; // Начинаем проверять с этого числа

            while (primes.Count < n)
            {
                if (IsPrimeFirstN(candidate, primes))
                {
                    primes.Add(candidate);
                }
                candidate += 2; // Проверяем только нечетные числа
            }
            return primes;
        }
        /// <summary>
        /// Проверка на простое число
        /// </summary>
        /// <param name="num">число из диапазона перебора</param>
        /// <param name="primes">список чисел</param>
        /// <returns></returns>
        public static bool IsPrimeFirstN(int num, List<int> primes)
        {
            if (num <= 1) return false;
            if (num == 2 || num == 3) return true;
            if (num % 2 == 0) return false;

            int sqrtNum = (int)Math.Sqrt(num);

            foreach (int prime in primes)
            {
                if (prime > sqrtNum)
                    break;

                if (num % prime == 0)
                    return false;
            }

            return true;
        }
        /// <summary>
        /// Вывод первых N простых чисел
        /// </summary>
        /// <param name="n">количество чисел</param>
        /// <returns>первые N простых чисел</returns>
        public static string PrintFirstNPrimes(int n)
        {
            List<int> primes = GenerateFirstNPrimes(n);
            return($"Первые {n} простых чисел: {string.Join(", ", primes)}");
        }

        public static List<int> GeneratePrimes(int n)
        {
            if (n <= 0)
                throw new ArgumentException("Число простых чисел должно быть положительным");

            if (n == 1)
                return new List<int> { 2 };

            // Оцениваем верхнюю границу для решета
            int upperLimit = EstimateUpperBound(n);
            bool[] isPrime = new bool[upperLimit + 1];
            InitializeSieve(isPrime);

            ApplySieve(isPrime);

            return ExtractPrimes(isPrime, n);
        }
        /// <summary>
        /// Оцениваем верхнюю границу для решета
        /// </summary>
        /// <param name="n">количество чисел</param>
        /// <returns>верхнюю границу решета</returns>
        public static int EstimateUpperBound(int n)
        {
            // Теорема о распределении простых чисел: π(n) ~ n/ln(n)
            // Решаем обратную задачу: найти x такой что π(x) ≈ n
            if (n <= 10) return 30;

            double x = n * Math.Log(n) + n * Math.Log(Math.Log(n));
            return (int)Math.Ceiling(x);
        }
        /// <summary>
        /// Инициализация решета
        /// </summary>
        /// <param name="isPrime">Список простых чисел</param>
        public static void InitializeSieve(bool[] isPrime)
        {
            for (int i = 2; i < isPrime.Length; i++)
                isPrime[i] = true;
        }
        /// <summary>
        /// Применение решета Эратосфена
        /// </summary>
        /// <param name="isPrime">список простых чисел</param>
        public static void ApplySieve(bool[] isPrime)
        {
            for (int p = 2; p * p < isPrime.Length; p++)
            {
                if (isPrime[p])
                {
                    for (int multiple = p * p; multiple < isPrime.Length; multiple += p)
                        isPrime[multiple] = false;
                }
            }
        }
        /// <summary>
        /// Извлечение первых N чисел из решета
        /// </summary>
        /// <param name="isPrime">список простых чисел</param>
        /// <param name="n">количество числе</param>
        /// <returns></returns>
        public static List<int> ExtractPrimes(bool[] isPrime, int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < isPrime.Length && primes.Count < n; i++)
            {
                if (isPrime[i])
                    primes.Add(i);
            }
            return primes;
        }
        /// <summary>
        /// Вывод списка простых чисел
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Список первых N простых чисел</returns>
        public static string PrintPrimes(int n)
        {
            List<int> primes = GeneratePrimes(n);
            return($"Первые {n} простых чисел: {string.Join(", ", primes)}");

        }
        /// <summary>
        /// Нахождение НОД (алгоритм Эвклида)
        /// </summary>
        /// <param name="n">первое число</param>
        /// <param name="m">второе число</param>
        /// <returns>наибольший общий делитель</returns>
        public static int NOD(int n, int m)
        {

            while (m != 0)
            {
                int remainder = n % m;
                n = m;
                m = remainder;
            }
            return n;
        }
        /// <summary>
        /// Нахождение НОК
        /// </summary>
        /// <param name="n">первое число</param>
        /// <param name="m">второе число</param>
        /// <returns>наименьшее общее кратное</returns>
        public static int NOK(int n, int m)
        {
            if (n == 0 || m == 0)
                return 0;

            int max = Math.Max(n, m);
            int min = Math.Min(n, m);
            int lcm = max;

            while (lcm % min != 0)
            {
                lcm += max;
            }
            return lcm;
        }
    }
}
