
public class dispatcher {

	private int timerkeep;
	private Proceso dis;
	
	public dispatcher() 
	{
		timerkeep = 1;
		dis = null;
	}
	
	
	public Proceso getDis() {
		return dis;
	}


	public void setDis(Proceso dis) {
		this.dis = dis;
	}


	public boolean haydispatcherprocess() 
	{
		if(dis == null) 
	    return true;
		
		return false;
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
