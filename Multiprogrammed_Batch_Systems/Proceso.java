import java.util.Random;

public class Proceso   {

	private int size;
	private int pid;
	private int prioridad;
	
	
	
	
	
	public int getPrioridad() {
		return prioridad;
	}


	public void setPrioridad(int prioridad) {
		this.prioridad = prioridad;
	}


	
	public int getSize() 
	{
		return size;
	}


	public void setSize(int size) 
	{
		this.size = size;
	}


	public String toString() 
	{
		return "PID :" + pid +" | "+"Size:"+ size +" Prioridad: "+ prioridad;
	}
	
	
	public Proceso() 
	{
		pid= 1;
		size= getRandomsize();
		prioridad = getRandomPrioridad();
	}
	
	public Proceso(int id) 
	{
		pid=id;
		size = getRandomsize();
		prioridad = getRandomPrioridad();
	}
	
	
  public int getRandomsize() 
  {
	  
	 Random rand = new Random();
	 int n = rand.nextInt(10) + 1;
	 return this.size = n;
  }
	
  public int getRandomPrioridad() 
  {
	  
	 Random rand = new Random();
	 int n = rand.nextInt(10) + 1;
	 return this.prioridad = n;
  }
	
  

	
	public static void main(String[] args) {
		
		Proceso real = new Proceso();
		System.out.println(real);

	}

}
