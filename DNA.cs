using System;
					
public class Program
{
	public string DNA,Is_YN;
	public void Main()
	{
	input_DNA();
	}
	public void input_DNA(){
		while(true){
		DNA = Console.ReadLine();
		if(IsValidSequence(DNA)){
			Console.WriteLine("Current half DNA sequence : "+ DNA);
			Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
			switch(Is_YN){
				case "Y" :
				Console.WriteLine("Replicated half DNA sequence : "+  ReplicateSeqeunce(DNA));		
				break;
				case "N" :
						
				break;
				default :
				Console.WriteLine("Please input Y or N.");	
				break;	
			}
		}else{
			Console.WriteLine("That half DNA sequence is invalid.");
		}
			Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
			Is_YN = Console.ReadLine();
			if(Is_YN == "N"){
			break;	
			}else if(Is_YN != "Y"||Is_YN != "N"){
			Console.WriteLine("Please input Y or N.");
			}
		}
	}
	static bool IsValidSequence(string halfDNASequence)
{
    foreach(char nucleotide in halfDNASequence)
    {
        if(!"ATCG".Contains(nucleotide.ToString()))
        {
            return false;
        }
    }
    return true;
	}
	static string ReplicateSeqeunce(string halfDNASequence)
{
    string result = "";
    foreach(char nucleotide in halfDNASequence)
    {
        result += "TAGC"["ATCG".IndexOf(nucleotide)];
    }
    return result;
}

}

