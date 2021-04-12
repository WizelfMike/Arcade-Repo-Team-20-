using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Cube;


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ouch");
    }

    
    
}
