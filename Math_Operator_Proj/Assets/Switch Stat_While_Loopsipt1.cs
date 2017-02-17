using UnityEngine;
using System.Collections;

public class SwitchStat_While_Loopsipt1 : MonoBehaviour {
	
	// First Switch example{
	char grade = 'A';
	
	void Start ()
	{
	/*School's grade*/
	

		switch(grade){


		case 'A':
			print ("Excellent");
			break;
		case 'B':
			print ("Good job");
			break;
	
		case 'C':
			print ("Good but needs improvement");
			break;
		case 'D':
			print("Acceptable");
			break;
	
		case 'F':
			print("Inacceptable");
			break;
	
		default:
			print("Invalid grade");
			break;
		}
		print("Your grade is: " + grade);

}
	// Update is called once per frame
	void Update () {
	
	}
}

	
	//Second 