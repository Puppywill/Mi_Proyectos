import javax.swing.DefaultListModel;

public class Sistemaoperativo {

	public static void main(String[] args) {
		DefaultListModel<Proceso>dispatcher = new DefaultListModel<Proceso>();
		RandomGeneral r = new RandomGeneral();
		CPU cpu = new CPU();
		
		r.setProabilidad(50);

		for(int x= 1 ; x<=10 ; x++) 
		{
			Proceso p = r.getRandomGeneral();
			
			if(p !=null) 
			{
				dispatcher.addElement(p);
			}
		}
		
		cpu.excute(dispatcher);
	}

}
