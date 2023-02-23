import javax.swing.DefaultListModel;

public class CPU {

	private int id;
	private int program_counter;
	private Proceso exec_process;

	public CPU() 
	{
		program_counter = 1;
		exec_process = null;
		System.out.println("Se creo un cpu nuevo...");

	}

	public int getProgram_counter() 
	{
		return program_counter;
	}

	public void setProgram_counter(int program_counter) 
	{
		this.program_counter = program_counter;
	}

	public Proceso getExecutingProcess() 
	{
		return this.exec_process;

	}

	public void setexec_process(Proceso p)
	{
		if (isAvailable()) {
			this.exec_process = p;
			System.out.println("Se anadio el procesador: " + p + " al cpu: " + id);
		}

	}

	public boolean isAvailable() 
	{
		if (exec_process == null)
			return true;

		return false;
	}

	public void clear() 
	{
		this.exec_process = null;
		this.program_counter = 1;
	}

	public void excute(DefaultListModel<Proceso>dispatcher) 
	{
		do
		{
			
			if(isAvailable() == true) 
			{
				exec_process= dispatcher.elementAt(0);
				System.out.println("Ejecutando: "+ exec_process);
			if(exec_process == dispatcher.elementAt(0)) 
			{
				dispatcher.removeElementAt(0);
			}
			
			for(int pc = program_counter; pc <=exec_process.getSize();pc++ ) 
			{
				program_counter = pc ;
			    System.out.println("PC:"+ pc);
				
			if(program_counter==exec_process.getSize()) 
			{
				System.out.println(exec_process+" Terminado");
			}
			
			}
			
			clear();
			
			
			}
		}
		while(dispatcher.getSize() !=0); 
	}
	
	
	public String toString() 
	{
		if (isAvailable() == true) 
		{
			return "CPU:" + id + " Tiene " + this.exec_process;
		}

		return "CPU:" + id + "no ningun processo........";
	}

	public static void main(String[] args) 
	{
//		// TODO Auto-generated method stub
//		CPU cpu = new CPU();
//
//		Proceso p = new Proceso();
//
//		cpu.isAvailable(p);
//
//		System.out.println(cpu);
//		System.out.println(p);
		
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
