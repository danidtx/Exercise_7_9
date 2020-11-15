using System;

public class Average{
	
	public static void Main()
	{
		double suma=0, num, counterNums=0, average;
		string checkEnd;
		
		Console.Write ("Insert a mark: ");
		checkEnd=Console.ReadLine();
		
		while (checkEnd!="end")
		{ 
		num=Convert.ToDouble(checkEnd);
		counterNums++;  
		suma+=num; 
		Console.Write ("Insert a mark: ");
		checkEnd=Console.ReadLine();
		}
		
	if (counterNums!=0)
	{
		average=suma/counterNums; 
		Console.WriteLine("The average is {0}.",average);
	}
