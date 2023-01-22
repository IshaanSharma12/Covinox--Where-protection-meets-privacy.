/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaassignment1;
import java.util.Scanner;
/**
 *
 * @author Windows
 */
public class JavaAssignment1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      Scanner input= new Scanner(System.in);
        
// Declairing the Variables
int num1;
int num2;
int num3;
int num4;
int num5;

int positivenum=0;
int negativenum=0;
int zeronum=0;

// Inputting all the numbers 
System.out.println("Please enter the first number");
num1= input.nextInt();

System.out.println("Please enter the second number");
num2= input.nextInt();

System.out.println("Please enter the third number");
num3= input.nextInt();

System.out.println("Please enter the fourth number");
num4= input.nextInt();

System.out.println("Please enter the fifth number");
num5= input.nextInt();

// Using the if else statements to check the inputs of the numbers and updating the +ve, -ve or 0

// Counting the positive numbers

if(num1>0)
    positivenum+=1;
if(num2>0)
    positivenum+=1;
if(num3>0)
    positivenum+=1;
if(num4>0)
    positivenum+=1;
if(num5>0)
    positivenum+=1;

// Counting the negative numbers

if(num1<0)
    negativenum+=1;
if(num2<0)
    negativenum+=1;
if(num3<0)
    negativenum+=1;
if(num4<0)
    negativenum+=1;
if(num5<0)
    negativenum+=1;

// Counting the equal to zero numbers

if(num1==0)
    zeronum+=1;
if(num2==0)
    zeronum+=1;
if(num3==0)
    zeronum+=1;
if(num4==0)
    zeronum+=1;
if(num5==0)
    zeronum+=1;

System.out.println();

System.out.printf("Positive numbers are=%d\n",positivenum);
System.out.printf("Negative numbers are=%d\n",negativenum);
System.out.printf("Zero numbers are=%d\n", zeronum);
        
    }
    
}
