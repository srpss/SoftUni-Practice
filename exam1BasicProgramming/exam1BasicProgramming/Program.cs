using System;
using System.Reflection;

public class Program
{
	public static void Main()
	{

		/*01. Change Bureau
		 * 
		 
		decimal bitcoins = decimal.Parse(Console.ReadLine());
		decimal yoan = decimal.Parse(Console.ReadLine());
		decimal intrest = decimal.Parse(Console.ReadLine());

		decimal bitcoinPrice = 1168 * bitcoins;
		decimal yoanPrice = 0.15m * yoan;
		decimal dollarPrice = 1.76m * yoanPrice;
		decimal euroPrice = 1.95m;

		decimal totalMoney = (bitcoinPrice + dollarPrice);
		decimal commisionMoney = totalMoney - (totalMoney * intrest / 100);
		decimal totaleuroPrice = (commisionMoney / euroPrice);

		Console.WriteLine($"{totaleuroPrice:F2}");


		01.Supplies for School
		

		decimal packageChem = decimal.Parse(Console.ReadLine());
		decimal packageMarkers = decimal.Parse(Console.ReadLine());
		decimal litterCleaner = decimal.Parse(Console.ReadLine());
		decimal saveUp = decimal.Parse(Console.ReadLine());

		decimal priceChem = packageChem * 5.80m;
		decimal priceMarkers = packageMarkers * 7.20m;
		decimal priceCleaner = litterCleaner * 1.20m;
		decimal totalPrice = priceChem + priceCleaner + priceMarkers;
		decimal endPrice = totalPrice - (totalPrice * saveUp / 100);
        Console.WriteLine($"{endPrice:F3}");
		

		02.Cat Walking
		

		decimal minSpend = decimal.Parse(Console.ReadLine());
		decimal walkCount = decimal.Parse(Console.ReadLine());
		decimal feedSize = decimal.Parse(Console.ReadLine());

		decimal totalTimeWalking = minSpend * walkCount;
		decimal burnedCal = totalTimeWalking * 5;
		decimal fiftyPerCal = feedSize - (feedSize * 50 / 100);
        if (burnedCal >= fiftyPerCal)
        {
            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCal}.");
		}
        else
        {
			Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCal}.");
		}
		

		02.Mountain Run
		

		decimal recordSeconds = decimal.Parse(Console.ReadLine());
		decimal distanceMeters = decimal.Parse(Console.ReadLine());
		decimal timeSeconds = decimal.Parse(Console.ReadLine());

		decimal climb = distanceMeters * timeSeconds;
		decimal addedTime = Math.Floor((distanceMeters / 50)) * 30;
		decimal totalTime = climb + addedTime;


        if (totalTime < recordSeconds)
        {
            Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
        }
        else
        {
			decimal neededTime = totalTime - recordSeconds;
			Console.WriteLine($"No! He was {neededTime:F2} seconds slower.");
		}


		03.Energy Booster


		string fruit = (Console.ReadLine());
		string sizeSet = (Console.ReadLine());
		decimal recSets = decimal.Parse(Console.ReadLine());

		decimal[] small = {56 * 2, 36.66m * 2, 42.10m * 2, 20 * 2};
		decimal [] big = { 28.70m * 5, 19.60m * 5, 24.80m * 5, 15.20m * 5 };
		decimal totalPrice = 0m;
        if (sizeSet == "big")
        {
			switch (fruit)
			{
				case "Watermelon":
					totalPrice = recSets * big[0];
					break;
				case "Mango":
					totalPrice = recSets * big[1];
					break;
				case "Pineapple":
					totalPrice = recSets * big[2];
					break;
				case "Raspberry":
					totalPrice = recSets * big[3];
					break;

				default:
					break;
			}
		}
        else
        {
			switch (fruit)
			{
				case "Watermelon":
					totalPrice = recSets * small[0];
					break;
				case "Mango":
					totalPrice = recSets * small[1];
					break;
				case "Pineapple":
					totalPrice = recSets * small[2];
					break;
				case "Raspberry":
					totalPrice = recSets * small[3];
					break;

				default:
					break;
			}
		}

        if (totalPrice >= 400 && totalPrice <= 1000)
        {
			totalPrice = totalPrice - (totalPrice * 15 / 100);
        }
        else if (totalPrice > 1000)
        {
			totalPrice = totalPrice - (totalPrice * 50 / 100);

		}
        
		Console.WriteLine($"{totalPrice:F2} lv.");
		
		 
		

		04. Food for Pets
		  

		decimal totalDays = decimal.Parse(Console.ReadLine());
		decimal totalFood = decimal.Parse(Console.ReadLine());
		decimal totalEaten = 0;
		decimal totalPerEaten = 0;
		decimal totalDogEaten = 0;
		decimal totalCatEaten = 0;
		decimal biscuits = 0;
		int counter = 0;
		for (int i = 0; i < totalDays; i++)
        {
			
			decimal dogFeed = decimal.Parse(Console.ReadLine());
			decimal catFeed = decimal.Parse(Console.ReadLine());
			totalDogEaten += dogFeed;
			totalCatEaten += catFeed;



			counter++;
			if (counter%3 == 0)
            {
				biscuits += dogFeed + catFeed - ((dogFeed + catFeed) * 90 / 100);
            }
		}

		totalEaten = totalDogEaten + totalCatEaten;
		totalPerEaten = (totalEaten / totalFood) * 100;
		totalDogEaten = (totalDogEaten / totalEaten) * 100;
		totalCatEaten = (totalCatEaten / totalEaten) * 100;

		Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
		Console.WriteLine($"{totalPerEaten:F2}% of the food has been eaten.");
		Console.WriteLine($"{totalDogEaten:F2}% eaten from the dog.");
		Console.WriteLine($"{totalCatEaten:F2}% eaten from the cat.");


		05. Care of Puppy
		

		decimal totalFood = decimal.Parse(Console.ReadLine()) * 1000;
		decimal eatenFood = 0;
		string input = Console.ReadLine();
		while (input != "Adopted")
        {
			eatenFood += decimal.Parse(input);


			input = Console.ReadLine();
		}

        if (totalFood >= eatenFood)
        {
			totalFood -= eatenFood;

			Console.WriteLine($"Food is enough! Leftovers: {totalFood} grams.");
        }
        else
        {

			eatenFood -= totalFood;
            Console.WriteLine($"Food is not enough. You need {eatenFood} grams more.");
        }

		06. Tournament of Christmas
		

		decimal days = decimal.Parse(Console.ReadLine());
		decimal winnings = 0;
		int countWin = 0;
		int countLoss = 0;
		int totalcountWin = 0;
		int totalcountLoss = 0;
		decimal currentWinnings = 0;
		for (int i = 0; i < days; i++)
        {
			currentWinnings = 0;
			countWin = 0;
			countLoss = 0;
			string input = Console.ReadLine();
			string result = Console.ReadLine();
			while (input != "Finish")
		{

                if (result == "win")
                {
					currentWinnings += 20;
					countWin++;
					totalcountWin++;

				}
				else
                {
					countLoss++;
					totalcountLoss++;
				}
				input = Console.ReadLine();
                if (input == "Finish")
                {
					break;
                }				
			result = Console.ReadLine();
		}
            if (countWin > countLoss)
            {
				currentWinnings = currentWinnings + (currentWinnings * 10 / 100);
            }
			winnings += currentWinnings;
		}

		if (totalcountWin > totalcountLoss)
		{

			winnings = winnings + (winnings * 20 / 100);
			Console.WriteLine($"You won the tournament! Total raised money: {winnings:F2}");
		}
		else
		{

			
			Console.WriteLine($"You lost the tournament! Total raised money: {winnings:F2}");
		}
		*/
	}
}
