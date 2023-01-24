package car_dealership;

public class Employee {

	public void handleCustomer(Customer cust, boolean finance ,Vehicle vechile) 
	{
		if(finance == true) 
		{
			
			double loanAmount = vechile.getPrice() - cust.getCashOnHand();
			runCreditHistory(cust , loanAmount);
			
		} else if (vechile.getPrice()<= cust.getCashOnHand()) 
		
		{
	        processTransaction(cust,vechile);
		}else 
		{
			System.out.print("Customer will need more money to purchase vehicle :/ "+ vechile);
		}
		
		
		
	}
	private void runCreditHistory(Customer cust, double loanAmount) 
	{
		System.out.print("Ran credit history for customer");
		System.out.print("Customer has been approved to purhas the vechicle");
	}
	
	public void processTransaction(Customer cust,Vehicle vechile) 
	{
		System.out.print("Customer has purchased the vehicle:"+ vechile +"for the price"+ vechile.getPrice());
	}
	
	
	
}
