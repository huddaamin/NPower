/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package stingvars;

/**
 *
 * @author Amin Hudda
 */
import javax.swing.JOptionPane;

public class StingVars {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
String first_name;
first_name = JOptionPane.showInputDialog("First Name", "Enter Your First Name");
        
String family_name;
family_name = JOptionPane.showInputDialog("Family", "Enter Your Family name");
        
String full_name;
full_name = "you are" + first_name + " " + family_name;
        
JOptionPane.showMessageDialog(null, full_name, "Name", JOptionPane.ERROR_MESSAGE);

System.exit(0);
        
    }
    
}
