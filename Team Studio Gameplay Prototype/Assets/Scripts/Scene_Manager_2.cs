using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Manager_2 : MonoBehaviour {
	
	public static bool Is_Object_Selected; // creating a bool to be edited if an object is selected

	public static string Selected_Object_Name; // a string to get the name of the selected object



	// Use this for initialization
	void Start () {

		Is_Object_Selected = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Selected_Object_Name);

	}
}
