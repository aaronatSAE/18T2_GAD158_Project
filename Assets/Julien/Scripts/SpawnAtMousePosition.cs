using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAtMousePosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    Ray myRay; //Create the ray
    RaycastHit hit; //Create the raycast hit
    public GameObject objectToInstantiate; // Creates a public GameObject in the inspector

	// Update is called once per frame
	void Update () {

        myRay = Camera.main.ScreenPointToRay(Input.mousePosition); // Tells the ray that it will come from the center of the main camera to the mouse Vector direction

        if (Physics.Raycast(myRay, out hit))
        {

            if (Input.GetMouseButtonDown(0))// If the left/(0) mouse button is down
            {

                Instantiate(objectToInstantiate, hit.point, Quaternion.identity); //This creates a prefab where ever the mouse is clicked

            }

        }


	}
}
