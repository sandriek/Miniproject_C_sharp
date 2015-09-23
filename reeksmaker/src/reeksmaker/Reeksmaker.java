/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package reeksmaker;

/**
 *
 * @author jeroen
 */
public class Reeksmaker {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        char[] a = {'p', 'r', 'g'};
        char[] b = {'f', 's', 'e'};
        char[] c = {'1', '2', '3'};
        char[] d = {'o', 's', 'd'};
        new Reeksmaker(a, b, c, d);
    }
    
    public Reeksmaker(char[] first, char[] second, char[] third, char[] fourth){
        for(char a : first){
            for(char b : second){
                for(char c : third){
                    for(char d : fourth){
                        System.out.println("" + a + b + c + d);
                    }
                }
            }
        }        
    }
}
