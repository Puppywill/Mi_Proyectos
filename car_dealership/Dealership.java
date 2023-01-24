package car_dealership;

public class Dealership {

	public static void main(String[] args) {
		
		Customer cust1 = new Customer();
        cust1.setName("Tom");
        cust1.setAddress ("123 Anything St");
        cust1.setCashOnHand(70000);
        
        Vehicle vehicle = new Vehicle("Toyota","4runner",60000);
        
        
        
        Employee emp = new Employee();
        
        cust1.purchaseCar(vehicle,emp,false);
        
        Vehicle car =new Vehicle("Honda","accord",50000);
        
        boolean value = car.equals(vehicle);
        System.out.println(value);
	}

}
