/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Amin Hudda
 */
public class ErrorChecking {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        System.out.println("Starting Main method");
        m1();
        System.out.println("End Main method");
          
        }
        static void m1() {
            System.out.println("Method One - m1");
            m2();
        }
        static void m2() {
            int x = 10;
            int y = 0;
            double z = x/y;
                    
                    System.out.println(z);
            System.out.println("Method Two - m2");
    }
    
}
