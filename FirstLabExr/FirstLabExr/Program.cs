using System;


    class Program
    {
    static void Main(string[] args)
    {
        /*
         *PRACTICE ON 09/JAN/2021* 
         
         01. *HELLO WORLD*

         Console.WriteLine("Hello SoftUni");
        
         02. *1 to 10*

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
       
        03. *AREA OF A SQUARE*

        int side = int.Parse(Console.ReadLine());
        int power = 2;
        int area = (int)Math.Pow(side, power);
            Console.WriteLine(area);
         
        04. *FROM INCHES TO CENTIMETERS*
         
        double inch = double.Parse(Console.ReadLine());
        double conversionToCentimeter = inch * 2.54D;
        Console.WriteLine(conversionToCentimeter);

        05. *HELLO NAME*
          
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        06. *Concatenate Data*
        

        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();
        string input = "You are " +firstName + " " + lastName + ", a " + age + "-years old person from "+ town + ".";
        Console.WriteLine(input);

        07.Projects Creation
        
        string name = Console.ReadLine();
        int totalProjects = int.Parse(Console.ReadLine());
        int time = totalProjects * 3;
        Console.WriteLine($"The architect {name} will need {time} hours to complete {totalProjects} project/s.");
        
        08.Pet Shop
        
        int dogs = int.Parse(Console.ReadLine());
        int otherAnimals = int.Parse(Console.ReadLine());
        double dogsFoodCost = dogs * 2.5D;
        int otherAnimalsCosts = otherAnimals * 4;

        Console.WriteLine(dogsFoodCost + otherAnimalsCosts + " lv.");
       
        09.Yard Greening
         
        double squareMeters = double.Parse(Console.ReadLine());
        double flatPrice = squareMeters * 7.61D;
        double tax = flatPrice * 0.18D;
        double finalPrice = flatPrice - tax;
        Console.WriteLine($"The final price is: {finalPrice} lv.");
        Console.WriteLine($"The discount is: {tax} lv.");
        string lastName = Console.ReadLine();
        

        ===============PRACTICE PROBLEM===============================
        

        01.USD to BGN

        double input = double.Parse(Console.ReadLine());

        double output = input * 1.79549D;
        Console.WriteLine($"{output:F2}");

        02.Radians to Degrees
        
       
            double input = double.Parse(Console.ReadLine());
        double convertPercent = Math.Round(input * 180 / Math.PI);
        Console.WriteLine(convertPercent);

        03.Deposit Calculator
       

        double deposit = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());
        double intrest = double.Parse(Console.ReadLine());

 
            
        double intrestRate = deposit * intrest/100;
        double intrestCalc = intrestRate / 12;
        double output = deposit + (time * intrestCalc);


        Console.WriteLine($"{output:F2}");

        04. Vacation books list
         

        double numPages = double.Parse(Console.ReadLine());
        double readRate = double.Parse(Console.ReadLine());
        double daysToRead = double.Parse(Console.ReadLine());

        double totalReadTime = numPages / readRate;
        double output = totalReadTime / daysToRead;

        Console.WriteLine($"{output}");

        05.Birthday party
        

        double roomSize = double.Parse(Console.ReadLine());
        double cakePrice = roomSize * 20 / 100;
        double drinkPrice = cakePrice* 45 / 100;
        double drinkPrice2 = cakePrice - drinkPrice;
        double animatorPrice = roomSize * 1 / 3;

        double totalPrice = roomSize + cakePrice + drinkPrice2 + animatorPrice;
        Console.WriteLine(totalPrice);

        06.Charity Campaign
        

        double days = double.Parse(Console.ReadLine());
        double manPower = double.Parse(Console.ReadLine());
        double cakes = double.Parse(Console.ReadLine());
        double gofreti = double.Parse(Console.ReadLine());
        double pancakes = double.Parse(Console.ReadLine());


        double cakePrice= cakes * 45;
        double gofretiPrice = gofreti * 5.80;
        double pancakePrice = pancakes * 3.20;

        double combinedPrice = (cakePrice + gofretiPrice + pancakePrice) * manPower;
        double wholeCampainRevenu = combinedPrice * days;
        double netRevenu = wholeCampainRevenu -  (wholeCampainRevenu* 1 / 8);
        Console.WriteLine(netRevenu);
    
        07. Fruit Market
        
        double priceStrawBerry = double.Parse(Console.ReadLine());
        double bannanaKG = double.Parse(Console.ReadLine());
        double orangesKG = double.Parse(Console.ReadLine());
        double berryKG = double.Parse(Console.ReadLine());
        double strawBerryKG = double.Parse(Console.ReadLine());

        double berryPrice = priceStrawBerry - (priceStrawBerry / 2);
        double orangePrice = berryPrice - (berryPrice * 40 / 100);
        double bannanPrice = berryPrice - (berryPrice * 80 / 100);

        double totalSum = priceStrawBerry * strawBerryKG + bannanaKG * bannanPrice + berryKG * berryPrice + orangePrice * orangesKG;
        Console.WriteLine(totalSum);

        
        08.Fish Tank

        
        double sizeCM = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double weigth = double.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());

        double areaAqua = sizeCM * height * weigth;
        double litters = areaAqua * 0.001;
        double litterNeeds = litters * (1 - (percent * 1 / 100));
        Console.WriteLine(litterNeeds);
        */
    }
}

