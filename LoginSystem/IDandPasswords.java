import java.util.HashMap;

public class IDandPasswords 
{

	HashMap<String,String> logininfo = new HashMap<String,String>();
	
	IDandPasswords()
	{
		logininfo.put("Oscar","Elbigfootpandillero");
		logininfo.put("William","Rosado");
		logininfo.put("Ambar","@1234");
	}
	
	protected 	HashMap getloginInfo() 
	{
		return logininfo;
	}
	
	
}
