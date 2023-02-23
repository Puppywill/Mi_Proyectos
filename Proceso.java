import java.util.Random;

public class Proceso {

	private int size;
	private int pid;
	
	
	
	
	
	
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
		return "PID :" + pid +" | "+"Size:"+ size;
	}
	
	
	public Proceso() 
	{
		pid= 1;
		size= getRandomsize();
	}
	
	public Proceso(int id) 
	{
		pid=id;
		size = getRandomsize();
		
	}
	
	
  public int getRandomsize() 
  {
	  
	 Random rand = new Random();
	 int n = rand.nextInt(10) + 1;
	 return this.size = n;
  }
	
	
	
	public static void main(String[] args) {
		
		Proceso real = new Proceso();
		System.out.println(real);

	}

}
