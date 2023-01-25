package Atm;
import java.util.*;

public class Atm {

	public static void main(String[] args) {
		
		int balance = 10000,withdraw,deposite;
		Scanner sc = new Scanner(System.in);
		int num;
		while(true)
		{	
			System.out.println("Welcome to the atm bro");
			System.out.println("1.Withdraw");
			System.out.println("2.Deposite");
			System.out.println("3.Check balance");
			System.out.println("4.Exit");
			num = sc.nextInt(); 
			switch(num) 
			{
				case 1:
					System.out.println("Enter amount to be withdraw");
				    withdraw = sc.nextInt();
				    
				    if(balance>=withdraw) 
				    {
				    	balance = balance-withdraw;
			    	System.out.println("Balance Ammount is:"+balance);
			    	System.out.println("Please collect money");
			    }
			    else 
			    {
			    	System.out.println("You dont have enough money for withdraw");
			    }
			    System.out.println("  ");
			    break;
			    
			  case 2:
			  {
				  System.out.println("Enter the amount to deposite");
				  deposite = sc.nextInt();
				  balance= balance+deposite;
				  
				  System.out.println("Balance Amount is:"+balance);
				  System.out.println("Money has been deposited succesfully");
				  System.out.println("  ");
				  break;
			  }
			  
			  case 3:
				  System.out.println("Balance of your Account is:" +balance);
				  System.out.println("  ");
				  break;
				  
			  case 4:	
				  System.exit(0);
				  System.out.println("  ");
				  
			  
			    
			}
			
			
		}	
		
		
		
		
	}

}
