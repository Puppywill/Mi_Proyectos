import java.awt.Font;

import javax.swing.JFrame;
import javax.swing.JLabel;

public class WelcomePage
{
	 JFrame frame = new JFrame();
	 JLabel welcomeLabel = new JLabel("Hello welcome to shoe!");
	 
	 WelcomePage(String userID)
	 {
		 
		 welcomeLabel.setBounds(100,150,350,45);
		 welcomeLabel.setFont(new Font(null,Font.PLAIN,25));
		 welcomeLabel.setText("Bienvenido "+userID);
		 
		 frame.add(welcomeLabel);
		 frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		 frame.setSize(420,420);
		 frame.setLayout(null);
		 frame.setVisible(true);
		 
	 }
	 
}
