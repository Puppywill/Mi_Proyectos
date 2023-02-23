import javax.swing.DefaultListModel;

public class Sistemaoperativo  {

private	DefaultListModel<Proceso>dispatcher;
private	DefaultListModel<Proceso>disco ;
private	CPU cpu;
private RandomGeneral ran;
private dispatcher mdp;
	
	
	
	public Sistemaoperativo() 
	{
		dispatcher = new DefaultListModel<Proceso>();
		disco = new DefaultListModel<Proceso>();
		cpu = new CPU();
		ran = new RandomGeneral();
		mdp = new dispatcher();
		
	}
	
	
	private void moverdispatcher() 
	{
		if(mdp.haydispatcherprocess()) 
		{
			if(!disco.isEmpty()) 
			{
				Proceso c = (Proceso) disco.remove(0);
				
				if(c.getPrioridad()==1) 
				{
				mdp.setDis(c);
				dispatcher.addElement(c);	
				}
				
				
			}
		}
	}
	

	public void clocktick() 
	{
		Proceso p = ran.getRandomProceso();
		
		if(p != null) 
		{
			disco.addElement(p);
			
		}
		
		
	
		this.moverdispatcher();
		
	}
	
	
	
	
	public void añadirdisk(int n) 
	{
		this.disco.addElement(ran.getRandomProceso());
	}
	
	public DefaultListModel<Proceso> getDispatcher()
	{
		return this.dispatcher;
	}


	public DefaultListModel<Proceso> getDisco() 
	{
		return this.disco;
	}


	public CPU getCpu() 
	{
		return this.cpu;
	}


	public RandomGeneral getRandomGeneral()
	{
		return this.ran;
	}
	
	public  DefaultListModel<Proceso> ordenDispatcher() 
	{
		for(int x=1; x<disco.getSize();x++) 
		{
			if(verificarpriodidad(disco.elementAt(x)))
			{
				dispatcher.addElement(disco.elementAt(x));
			}
		}
		return dispatcher;
	}
	
	
	public boolean verificarpriodidad(Proceso p) 
	{
		if(p.getPrioridad()==1) 
		{
			return true;
		}
		
		else if(1>p.getPrioridad() && p.getPrioridad()<10)
		{
			return true;
		}
		return false;
	}
	
	
	public void ejecutar() 
	{
		ordenDispatcher();
	}
	
	public static void main(String[] args) {
		
		
	
		
	}






	
}
