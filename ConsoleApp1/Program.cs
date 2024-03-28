using System;

using System.Text;


namespace ConsoleApp1
{
	internal class Program
	{
		static Char[] chars = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();

		static string generatePasssword(int len)
		{
			Random random = new Random();
			StringBuilder pass = new StringBuilder();

			for (int i = 0; i < len; i++)
			{
				int index = random.Next(chars.Length);
				pass.Append(chars[index]);
			}
			return pass.ToString();

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Сколько паролей надо сгенирировать");
			int count = int.Parse(Console.ReadLine());
			Console.WriteLine("Укажите длину пароля");
			int len = int.Parse(Console.ReadLine());
			for (int i = 0; i < count; i++)
			{
				string password = generatePasssword(len);
				Console.WriteLine(password);
			}

		}
	}
}
