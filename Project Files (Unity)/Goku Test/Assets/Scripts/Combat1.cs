using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat1 : MonoBehaviour
{
    public Animator Anim;


    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            Anim.SetTrigger("Punch2");
        }
    }
}
