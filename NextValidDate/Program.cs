using System;

namespace NextValidDate
{
    class Program
    {

        static bool CheckYear(int year)
        {
            return(year%4==0 && year%100 !=-0) ||(year%400==0);
        }
		static int DayMonth(int month, int year)
		{
			switch (month)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					return 31;
				case 4:
				case 6:
				case 9:
				case 11:
					return 30;
					break;
				case 2:
					if (CheckYear(year) == true)
						return 29;
					else
						return 28;

				default:
					return 0;
			}
				
		}
		static void NextDay(int day, int month, int year)
		{
			int DayinMonth = DayMonth(month, year);
			if (day < DayinMonth) 
			{
				day++;
			}
			else if (month < 12)     
			{
				day = 1; month++;
			}
			else                     
			{
				day = month = 1;
				year++;
			}
			Console.WriteLine($"Ngay ke tiep la: {day}/{month}/{year} ");
		}
		static void Main(string[] args)
        {
			Console.Write("Nhap day: ");
			int day = int.Parse(Console.ReadLine());
			Console.Write("Nhap thang: ");
			int month = int.Parse(Console.ReadLine());
			Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(day + "/" + month + "/"+ year);
			int DayInMonth = DayMonth(month, year);
			NextDay(day, month, year);
        }      
    }
}
