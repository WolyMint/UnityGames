using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){

		if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 100, 200, 50), "\nИграть!"))
			Application.LoadLevel ("Level1");
		
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 50), "\nВыход"))
			Application.Quit ();
	}

}
