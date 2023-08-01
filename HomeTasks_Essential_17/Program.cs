using System.Collections;

namespace HomeTasks_Essential_17
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Car> cars = new List<Car>() 
			{ 
				new Car() 
				{ 
					Mark = "BMW",
					Model = "V5",
					Year = 2013,
					Color = "White",		
				},
				new Car()
				{
					Mark = "Mercedes",
					Model = "Alpha",
					Year = 2017,
					Color = "Grey",
				},
				new Car()
				{
					Mark = "Mazda",
					Model = "C60",
					Year = 2023,
					Color = "Red",
				},
				new Car()
				{
					Mark = "Mazda",
					Model = "C50",
					Year = 2021,
					Color = "Blue",
				},
			};

			List<CarBuyer> carBuyers = new List<CarBuyer>()
			{
				new CarBuyer()
				{
					ModelCar = "Alpha",
					NameBuyer = "First Buyer",
					Telephone = "000000000",		
				},
				new CarBuyer()
				{
					ModelCar = "C60",
					NameBuyer = "Second Buyer",
					Telephone = "111111111",
				},
				new CarBuyer()
				{
					ModelCar = "V5",
					NameBuyer = "Third Buyer",
					Telephone = "222222222",
				},
			};

			var instance = from buyer in carBuyers
						   join car in cars
						   on buyer.ModelCar equals car.Model
						   select 
						   new { 
							   BuyerName = buyer.NameBuyer, 
							   Telephone = buyer.Telephone, 
							   Mark = car.Mark, 
							   Model = car.Model, 
							   Year = car.Year,
							   Color = car.Color,  
						   };

			foreach (var item in instance)
			{
                Console.WriteLine($"BuyerName: {item.BuyerName}\nTelephone: {item.Telephone}\nMark: {item.Mark}\nModel: {item.Model}\nYear: {item.Year}\nColor: {item.Color}");
				Console.WriteLine(new string('-', 20));
            }
        }
	}
}