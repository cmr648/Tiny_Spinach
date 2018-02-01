using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection_Object : MonoBehaviour {

	Renderer Original_Renderer; // creating a placeholder renderer to get the renderer of our gameobject

	public Color Selected_Color; // the color of an object if it becomes selected
	Color Original_Color; // creating a placeholder for our original color

	bool Object_Can_Move; // creating a bool to see if the gameobject can move

	// Use this for initialization
	void Start () {

		Original_Color = GetComponent<SpriteRenderer> ().color; // setting our original color to be the color of our sprite
	}
	
	// Update is called once per frame
	void Update () {

		Gyroscope_Move (); // turning our gyroscope move function to be on

	}

	void OnMouseDown(){ // checking to see if the mouse has clicked on this gameobjec


		if (Scene_Manager_2.Is_Object_Selected == false) { // checking to see that there is no selected object

			Scene_Manager_2.Selected_Object_Name = gameObject.name; // setting our selected gameobejct name to be this gameobject
			Scene_Manager_2.Is_Object_Selected = true; // setting our object selected to be equal to true
			GetComponent<SpriteRenderer>().color = new Color (Selected_Color.r,Selected_Color.g,Selected_Color.b); // setting our gameobjects color to be our selected color
			Object_Can_Move = true; // setting our object to be able to move

		} else {
			if (Scene_Manager_2.Selected_Object_Name == gameObject.name) { // if the selected object is this game object

				Scene_Manager_2.Is_Object_Selected = false; // select an object to be false
				GetComponent<SpriteRenderer>().color = new Color(Original_Color.r,Original_Color.g,Original_Color.b); // resetting our gaemobject to its original color
				Object_Can_Move = false; // setting our object to no longer be able to move
			}

		}
			

	}
		
	void Gyroscope_Move(){ // creating a seperate function for all gyroscope movement
		if (Object_Can_Move) { // checking to see if our object can move setting is on
			transform.Translate (Input.acceleration.x, 0, 0); // moving our object using the gyroscope
			//transform.Rotate(-Vector3.forward,Input.acceleration.x *Time.deltaTime *1000); // ROtation code
		}
	}


}
