using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Animator Anim;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            Anim.SetBool("Punch", true);
        }
        else
        {
            Anim.SetBool("Punch", false);
        }
    }
}
