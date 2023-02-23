import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JList;
import javax.swing.JScrollPane;
import javax.swing.border.TitledBorder;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class GUI {

	private JFrame frame;
    private Sistemaoperativo sto;
  
    

    
    
	/**
	 * Launch the application.
	 */
	public static void main(String[] args)
	{
		EventQueue.invokeLater(new Runnable()
		{
			public void run() 
			{
				try {
					GUI window = new GUI();
					window.frame.setVisible(true);
				} 
				catch (Exception e) 
				{
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public GUI() 
	{
		sto = new Sistemaoperativo();
		initialize();
		
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() 
	{
		frame = new JFrame();
		frame.setBounds(100, 100, 647, 446);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(34, 84, 211, 184);
		frame.getContentPane().add(scrollPane);
		
		JList Dispatcher = new JList();
		Dispatcher.setBorder(new TitledBorder(null, "Dispatcher", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		Dispatcher.setModel(sto.getDispatcher());
		scrollPane.setViewportView(Dispatcher);
		
		JScrollPane scrollPane_1 = new JScrollPane();
		scrollPane_1.setBounds(343, 84, 232, 173);
		frame.getContentPane().add(scrollPane_1);
		
		JList Disk = new JList();
		Disk.setBorder(new TitledBorder(null, "Disk", TitledBorder.LEADING, TitledBorder.TOP, null, null));
		Disk.setModel(sto.getDisco());
		scrollPane_1.setViewportView(Disk);
		
		JButton btnNewButton = new JButton("Click_tick");
		
		btnNewButton.addActionListener(new ActionListener() 
		{
			public void actionPerformed(ActionEvent e)
			{
				
				sto.clocktick();
				
				
			}
			
		});
		btnNewButton.setBounds(227, 313, 159, 51);
		frame.getContentPane().add(btnNewButton);
	}
}
