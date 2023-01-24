package Calculator;
import java.util.Scanner;




public class Calculator {

	public static void main(String[] args)
	{
		
		Scanner scan = new Scanner(System.in);

		System.out.println("Choose your Operation");
		System.out.println("1 for addition");
		System.out.println("2 for sbtraction");
		System.out.println("3 for Multiplication");
		System.out.println("4 for Division");
		
		int choose =scan.nextInt();
		
		System.out.println("Enter Two Number");
		int x = scan.nextInt();
		int y = scan.nextInt();
		
		
		if(choose == 1) 
		{
	       System.out.println("The ansewr is:"+add(x,y));
	       
		}
		else if(choose==2) 
		{
			 System.out.println("The ansewr is:"+sub(x,y));
		}
		else if(choose==3) 
		{
			 System.out.println("The ansewr is:"+mul(x,y));
		}
		else if(choose==4) 
		{
			 System.out.println("The ansewr is:"+div(x,y));
		}
		
		
		
		else 
		{
			System.out.println("You are out of range");
		}
	}

	public static int add(int x ,int y) 
	{
		int n;
		n=x+y;
		return n;
	}
	
	public static int sub(int x ,int y) 
	{
		int n;
		n=x-y;
		return n;

	}
	
	public static int mul(int x ,int y) 
	{
		int n;
		n=x*y;
		return n;

	}
	
	public static int div(int x ,int y) 
	{
		int n;
		n=x/y;
		return n;

	}
	
//	public static void Exit() 
//	{
//		String user;
//		Scanner userchoice = new Scanner(System.in);
//		System.out.println("Are you sure to leave [Y] or [N]");
//		user=userchoice.nextLine();
//		if(user=="Y") 
//		{
//			System.out.println("Please come back soon");
//		}
//		else if(user=="N")
//		{
//		
//		return;
//		}
	}
	

