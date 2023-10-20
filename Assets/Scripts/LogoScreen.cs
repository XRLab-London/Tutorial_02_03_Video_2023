using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScreen : MonoBehaviour
{
	//PSEUDO CODE: Declare(Create) a public variable for a Game Object, Type: Renderer
	//FUNCTION: Accesses "this" Game Object by default, or can drag in another in Inspector Box....
	Renderer goRend;

	void Start()
	{
		//PSEUDO CODE: Initialize variable with Mesh Renderer from Game Object which this script is attached to... 
		//...(default), or use "this" to specify  more precisely, or drag in different Game Object to Inspector Box. 
		//make sure renderer is "on"
		//ALTERNATE: use "this"
		goRend = GetComponent<Renderer>();
		goRend.enabled = true;

	}
	void Update()
	{
		//PSEUDO CODE: Check for Key input (Space Key)
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//PSEUDO CODE: Turn on/off mesh renderer
			//ALTERNATE: use "this"
			//this.GetComponent<Renderer>().enabled = !this.GetComponent<Renderer>().enabled;
			goRend.enabled = !goRend.enabled;
		}


	}

}

