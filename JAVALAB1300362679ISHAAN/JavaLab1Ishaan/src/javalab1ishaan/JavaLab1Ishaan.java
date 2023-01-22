/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javalab1ishaan;
import java.util.Scanner;
/**
 *
 * @author Windows
 */
public class JavaLab1Ishaan {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input= new Scanner(System.in);
        
        int num1;
        num1= input.nextInt();
        System.out.println("Please Enter The Number 1 ");
        int num2;
        num2= input.nextInt();
        System.out.println("Please Enter The Number 2");
        int num3;
        num3= input.nextInt();
        System.out.println("Please Enter the Number 3");
        int num4;
        num4= input.nextInt();
        System.out.println("Please Enter the Number 4");
        int num5;
        num5= input.nextInt();
        System.out.println("Please Enter the Number 5");
        int negative=0;
        
        int positive=0;
       
        int zero=0;
       
        
        if(num1<0){
        
            negative=negative+1;
        
        }
        
        if(num1==0){
         
        zero=zero+1;
            
        
        }
        
        if(num1>0){
        
        positive=positive+1;
            
        }
        
        if(num2<0){
        
        negative=negative+1;
        
        }
        
        if(num2==0){
        
            negative=negative+1;
        
        }
        
        if(num2>0){
        
        positive=positive+1;
        
        }
        
        if(num3<0){
        
        negative=negative+1;
        }
        
        if(num3==0){
        
            zero=zero+1;
        
        }
        
        if(num3>0){
        
        positive=positive+1;
            
        }
        
        if(num4<0){
        
        negative=negative+1;
        
        }
        
        if(num4==0){
        
        zero=zero+1;
        
        }
        
        if(num4>0){
        
        positive=positive+1;
        }
        
        
        if(num5<0){
        
        negative=negative+1;
            
        }
        
        if(num5==0)
        
            zero=zero+1;
        
        
        
        if(num5>0){
        
        positive=positive+1;
        
        }
        System.out.println();
        System.out.println("Positive numbers are"+ positive);
        System.out.println("Negative numbers are"+ negative);
        System.out.println("Zero numbers are" + zero);
    }
    
}
