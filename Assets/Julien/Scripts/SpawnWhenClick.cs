using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class SpawnWhenClick : MonoBehaviour
    {
        public GameObject objectToSpawn;
        GameObject prefabClone;
    
        void Update()
        {
            // if the left mouse button is clicked
            if (Input.GetMouseButtonDown(0))
            {

            // create a clone of the selected prefab in the position of the spawn point 
            prefabClone = Instantiate(objectToSpawn, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
            
            }
        }

    
}
