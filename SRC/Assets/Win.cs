using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		
	}
	void OnGUI(){
		

		GUI.Box(new Rect(Screen.width/2 - 300, 100, 600, 800), "The Interesting History \n\n YOU WIN!!!");


		if (GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 100, 200, 50), "\nИграть!"))
			Application.LoadLevel ("level1");

		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 + 100, 200, 50), "\nВыход"))
			Application.Quit ();
	}
}
