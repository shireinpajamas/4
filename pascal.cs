using System;
					
public class Program
{
	
	public static void Main()
	{
	int row,val=0;
	row = Int32.Parse(Console.ReadLine());
	for(int i = 0;i<row;i++){
		for(int k=1;k<=row-i;k++){ 
			Console.Write(" ");	
		}
		for(int j=0;j<= i;j++){
			if(j==0||i==0) val = 1;
			else val = val *(i-j+1)/j;
			Console.Write(val + " ");
		}
		Console.WriteLine();
	}
	}
}

