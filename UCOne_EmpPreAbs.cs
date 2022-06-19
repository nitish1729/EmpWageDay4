//  Check Employee is Present or Absent
//  Use ((RANDOM)) for Attendance Check

const int FullTime = 1;

Random ran = new Random(0);
int AttenCheck = ran.Next(0, 2);
if (AttenCheck == FullTime)
{
    Console.WriteLine("Emp is Present");
}
else
{
    Console.WriteLine("Emp is Absent");
}