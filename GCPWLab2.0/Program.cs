

Console.WriteLine("Hello. Welcome to the Buffet. All you can eat for $9.99. We offer water and soda to drink with an additional charge of $1.49 for a soda. Unfortunately we're unable to accommodate parties of more than 6 people at this time.  How many people will be dining with us today? ");

string SizeOfParty = Console.ReadLine();
int size = int.Parse(SizeOfParty);


int water = 0;
int soda = 0;
if (size <= 6)
{
	Console.WriteLine($" Sounds good. A table for " + SizeOfParty + " right this way.");

	for (int p = 0; p < size; p++)

	{
		Console.WriteLine($" Customer {p + 1} what would you like to drink?");
		var choice = Console.ReadLine();
		Console.WriteLine(choice + " for customer " + (p + 1));
		if (choice == "soda")
		{
			soda++;
		}
		else if (choice == "water")
		{
			water++;
		}






		else

			Console.WriteLine(" I’m sorry we don't have that available. Next time please choose from the options that we do have ");

		



	}

	decimal bill = (decimal)((size * 9.99) + (soda * 1.49));

	Console.WriteLine($" Sounds good. So that will be " + water + " waters and " + soda + " sodas feel free to grab your food. I'll be right back with your bill which will be $" + bill);
}
	
	if (size >= 7)
		Console.WriteLine(" I'm sorry, we're only able to accommodate parties of 6 or less at this time. Please come back soon! ");
				

	