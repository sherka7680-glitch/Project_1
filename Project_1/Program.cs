using System.Dynamic;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваше возраст: ");
            int age=ReadInt("Пожалуйста, введите корректный возраст (число): ",0,200);
            Console.WriteLine($"Привет, {name}! Тебе {age} лет.");
            Console.WriteLine($"Через 5 лет те будет {age + 5} лет.");
            Console.WriteLine("===========================================================================");
            Console.Write("Введите рост: ");
            double дутпер=ReadDouble("Пожалуйста, введите корректный возраст (число): ", 0, 300);
            Console.Write("Введите вес в кг: ");
            double massa= ReadDouble("Пожалуйста, введите корректный возраст (число): ", 0, 300);
          
            double imt = massa / Math.Pow(дутпер/100, 2);
            Console.WriteLine($"Ваш индекс массы тела: {massa / Math.Pow(дутпер/100, 2)}");
            string res;
            if (imt > 30)
            {
                res = "У вас ожирение";
                Console.WriteLine();
            }
            else if (imt > 25)
            {
                res = "У вас избыточный вес";
                Console.WriteLine(res);
            }
            else if (imt > 18.5)
            {
                res = "У вас нормальный вес";
                Console.WriteLine(res);
            }
            else
            {
                res = "У вас недостаточный вес";
                Console.WriteLine(res);
            }
            Console.WriteLine("===========================================================================");
             Console.Write("Введите возраст: ");
            long Фge = ReadInt("Пожалуйста, введите корректный возраст (число): ", 0, 200);
            const int months = 12;
            const double weeks =4.35;
            const int days = 7;
            const int clock = 24;
            const int minut = 60;
            const int second = 60;
            
            long monthsa = Фge * months;
            long weeksa =(long)(monthsa* weeks);
            long daysa = weeksa*days;
            long  clocka = daysa*clock;
            long minuta= clocka*minut;
            long seconda = minuta*second;
            Console.WriteLine($"Возраст в месяцах {monthsa}");
            Console.WriteLine($"Возраст в неделях {weeksa.ToString("N0")}");
            Console.WriteLine($"Возраст в днях {daysa.ToString("N0")}");
            Console.WriteLine($"Возраст в часах {clocka.ToString("N0")}");
            Console.WriteLine($"Возраст в минутах {minuta.ToString("N0")}");
            Console.WriteLine($"Возраст в секундах {seconda.ToString("N0")}");
            Console.WriteLine("===============================================================");
            Console.WriteLine($"═══════════════════════════════════════════════\r\n             ЛИЧНАЯ КАРТОЧКА\r\n═══════════════════════════════════════════════\r\nИмя       │ {name}\r\nВозраст   │ {age} лет\r\nРост      │ {дутпер} см\r\nВес       │ {massa} кг\r\n───────────────────────────────\r\nИМТ       │ {imt}\r\nСтатус    │ {res}\r\n═══════════════════════════════════════════════");
        }
        static int ReadInt(string prompt, int min, int max)
        {
           
            int age;
            while (!int.TryParse(Console.ReadLine(), out age)||age<min||age>max)
            {
                Console.Write(prompt);
            }
            return age;
        }
        static double ReadDouble(string prompt, double min, double max)
        {
            
            double age;
            while (!double.TryParse(Console.ReadLine(), out age) || age < min || age > max)
            {
                Console.Write(prompt);
            }
            return age;
        }

    }
}
