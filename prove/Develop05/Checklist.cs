namespace Develop05;

public class Checklist : Goal
{
	
	

	public Checklist(String n, String d, int p, int a, int c)
	{
		GSet_name(n);
		GSet_description(d);
		GSet_completed(0);
		GSet_amount(a);
		
		if( p != -1){ GSet_points(p);}
		if( c != -1){ GSet_completed(c);}
	}

	public override void Display() {
		
		if(GSet_completed(-1) >= GSet_amount(-1)) { Console.Write("[X] ");}
		else { Console.Write("[ ] "); }
        
		Console.Write(GSet_name(null)+ " ");
		Console.Write(GSet_description(null) + " ");
		Console.Write(GSet_completed(-1) + "/" + GSet_amount(-1));

	}
	
	public override String SaveOutput() {
		return "Checklist" + "|" + GSet_name(null) + "|" + GSet_description(null) + "|" + GSet_points(-1) + "|" + GSet_amount(-1) + "|" + GSet_completed(-1);
	}

	
}