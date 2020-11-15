using System;

class digits
{
 static void Main()
 {
     int oneDig = 0, twoDig = 0, threeDig = 0, moreDig = 0;
      Console.Write("Insert a number: ");
      
      // read the number as string to check the word "end"
      
      string checkEnd = Console.ReadLine();
      
     while(checkEnd!="end"){
int input = Convert.ToInt32(checkEnd);
       if(input != 0)
{
       if(input/10 == 0)
           oneDig ++;  
       else 
       if (input/100 == 0)
		twoDig ++;  
        else
        if (input/1000 == 0)
        threeDig ++;  
        else
           moreDig++;  
        }
      checkEnd = Console.ReadLine();
}

Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDig, twoDig, threeDig, moreDig); 


 }
}

