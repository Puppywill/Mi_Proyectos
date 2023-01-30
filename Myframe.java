import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.color.*;
import java.awt.event.*;
import javax.swing.*;

public class Myframe extends JFrame implements MouseListener{

	JLabel label;
	ImageIcon lebron;
	ImageIcon smile;
	ImageIcon sad;
	ImageIcon goat;
	
	
	
	Myframe()
	{
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setSize(500,500);
		this.setLayout(new FlowLayout());
		
		label = new JLabel();
		label.addMouseListener(this);
		
		smile = new ImageIcon("Media/happy.png");
		sad = new ImageIcon("Media/sad.png");
		lebron = new ImageIcon("Media/lebron.png");
		goat = new ImageIcon("media/goat.png");
		
		label.setIcon(smile);
		
		
		this.add(label);
		this.setVisible(true);
		this.pack();
		this.setLocationRelativeTo(null);
		this.setVisible(true);
		
		
	}

	@Override
	public void mouseClicked(MouseEvent e) 
	{
//		System.out.println("YOU CLICK THE MOUSE");
//		label.setBackground(Color.PINK);
		label.setIcon(smile);
	}

	@Override
	public void mousePressed(MouseEvent e) 
	{
//		System.out.println("YOUR PRESS THE MOUSE");
//		label.setBackground(Color.blue);
		label.setIcon(goat);
	}

	@Override
	public void mouseReleased(MouseEvent e)
	{
//		System.out.println("YOU RELEASES THE MOUSE");
//		label.setBackground(Color.green);
	}

	@Override
	public void mouseEntered(MouseEvent e) {
//		System.out.println("YOU enter the component");
//		label.setBackground(Color.yellow);
		label.setIcon(lebron);
	}

	@Override
	public void mouseExited(MouseEvent e) {
//		System.out.println("YOU EXIT THE COMPONENT");
//		label.setBackground(Color.gray);
		
		label.setIcon(sad);
	}
	
}
