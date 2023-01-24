import java.util.Scanner;

public class Main {

	public static void main(String[] args)
	{
	double x;
	double y; 
	double z;
	
	Scanner scanner = new Scanner(System.in);
	
	System.out.println("Entre su numero x:");
	x=scanner.nextDouble();
	System.out.println("Entre su numero y:");
	y=scanner.nextDouble();
	
	z= Math.sqrt((x*x)+(y*y));
	System.out.println("Su resultado:"+z);

	}

}
