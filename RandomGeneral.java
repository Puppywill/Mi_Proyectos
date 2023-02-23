import java.util.Random;

public class RandomGeneral {

	
private int proabilidad = 100;	

private int id;	

public RandomGeneral() 
{
	id=1;
	
}

public Proceso getRandomGeneral() 
{
	Random rand = new Random();
	 int n = rand.nextInt(100);
	 
	 if(n<=proabilidad) 
	 {
		 return new Proceso(id++);
	 }
	 else 
	 {
		 return null;
	 }
}



	public int getProabilidad()
	{
	return proabilidad;
}

public void setProabilidad(int proabilidad) {
	this.proabilidad = proabilidad;
}

	public static void main(String[] args) {
		RandomGeneral randomgeneral  = new RandomGeneral() ;
		
		randomgeneral.setProabilidad(50);
		
		for(int x= 1 ; x<=10 ; x++) 
		{
			Proceso p = randomgeneral.getRandomGeneral();
			
			if(p !=null) 
			{
				System.out.println(p);
			}
		}
		
		
		System.out.println(randomgeneral);

	}

}
