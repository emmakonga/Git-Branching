using UnityEngine;
using System.Collections;

public class MathOperators : MonoBehaviour {
    public int a = 12;
    public int b = 2;
    public int c = 3;
    public  int myInt;
    // Use this for initialization
    void Start()
    {
        //creates an int variable equal to A minus B
        int subInt = a - b;
        //creates an int variable equal to A plus B
        myInt = a + b;
        //creates an int variable equal to A times B
        int multInt = a * b;
        //creates an int variable equal to A divided by B
        int divInt = a / b;
        //creates an int variable equal to A modulus B
        int modInt = a % b;
        //creates an int variable equal (a + b) * c 
        int anotherInt = (a + b) * c;
        print(myInt);
      
        print(subInt);
        print(multInt);
        print(a * b);
        print(multInt * subInt);
        print(divInt);
        print(modInt);
        print(anotherInt);
    }
}
