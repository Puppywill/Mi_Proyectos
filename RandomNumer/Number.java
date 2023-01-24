import java.util.Random;
public class Number {
public static void main(String[] arg) 
{
	Random random = new Random();
	
	int x = random.nextInt(10)+1;
	
	double y = random.nextDouble(10);
	System.out.println(x);
	System.out.println(y);
	}
}
