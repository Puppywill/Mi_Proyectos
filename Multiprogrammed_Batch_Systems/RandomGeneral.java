import java.util.Random;

public class RandomGeneral {

	
private int proabilidad = 100;	

private int conteo;	

public RandomGeneral() 
{
	conteo=1;
	
}

public Proceso getRandomProceso() 
{
	
	Random var = new Random();
	
	
	int n = var.nextInt(100);
	
	if(n<=proabilidad) 
	{
		return new Proceso(conteo++);	
	}
	else
		return null;
	
	
	
	
}



	public int getProabilidad()
	{
	return proabilidad;
}

public void setProabilidad(int proabilidad) {
	this.proabilidad = proabilidad;
}
}