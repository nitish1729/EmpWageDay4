
// Calculating Wages for a Month  Assume 20 Working Day per Month

int WagePerHrs = 20;
int WorkingDay = 20;
int FullTime = 8;
int PartTime = 4;
int NoWork = 0;

for (int Day = 0; Day < WorkingDay; Day++)
{
	Random random = new Random();
	int AttenCheck = random.Next(0, 9);
	switch (AttenCheck)
	{
		case 8:
			Console.WriteLine("Emp is present ");
			Console.WriteLine("Total Wage : " + (WagePerHrs * FullTime));
			break;

		case 4:
			Console.WriteLine("Emp is HalfDayWork ");
			Console.WriteLine("Total Wage : " + (WagePerHrs * PartTime));
			break;

		Default:

			Console.WriteLine("Emp is Absent  ");
			Console.WriteLine("Total Wage : " + (WagePerHrs * NoWork));
			break;
	}

}