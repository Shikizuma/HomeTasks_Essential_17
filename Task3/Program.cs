using System.Text;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			var dictionary = new List<dynamic>
			{
				new { EnglishWord = "apple", RussianWord = "яблуко" },
				new { EnglishWord = "banana", RussianWord = "банан" },
				new { EnglishWord = "car", RussianWord = "автомобіль" },
				new { EnglishWord = "dog", RussianWord = "собака" },
				new { EnglishWord = "house", RussianWord = "дім" },
				new { EnglishWord = "sun", RussianWord = "сонце" },
				new { EnglishWord = "book", RussianWord = "книга" },
				new { EnglishWord = "computer", RussianWord = "комп'ютер" },
				new { EnglishWord = "music", RussianWord = "музика" },
				new { EnglishWord = "tree", RussianWord = "дерево" },
			};

			Console.WriteLine("Англо-Український словник:");
			foreach (var item in dictionary)
			{
				Console.WriteLine($"{item.EnglishWord} - {item.RussianWord}");
			}
		}
	}
}