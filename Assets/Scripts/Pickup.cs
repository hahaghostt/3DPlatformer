using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isinside = false;
    private void OnTriggerEnter(Collider other)
    {
        isinside = true;
        //if (Input.GetKeyDown(KeyCode.E))
        //Destroy (game.Object); 

    }
    private void OnTriggerExit(Collider other)
    {
        isinside = false;
        //if (Input.GetKeyDown(KeyCode.E))
        //Destroy (game.Object); 

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isinside == true)
            
        {

            Destroy(gameObject);

        }
    }
}
