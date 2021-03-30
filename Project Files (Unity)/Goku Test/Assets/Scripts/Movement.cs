using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Movementspeed;
    public Rigidbody rb;
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Movementspeed, 0, 0) * Time.deltaTime;
            Anim.SetBool("WalkRight", true);  
        }  else
        {
            Anim.SetBool("WalkRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-Movementspeed, 0, 0) * Time.deltaTime;
            Anim.SetBool("WalkBack", true);
        }   else {
            Anim.SetBool("WalkBack", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 2, 0);
        }
    }
}
