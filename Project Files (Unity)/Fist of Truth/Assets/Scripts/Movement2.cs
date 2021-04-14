using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(Movementspeed, 0, 0) * Time.deltaTime;
            Anim.SetBool("WalkBack", true);
        }
        else
        {
            Anim.SetBool("WalkBack", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-Movementspeed, 0, 0) * Time.deltaTime;
            Anim.SetBool("WalkRight", true);
        }
        else
        {
            Anim.SetBool("WalkRight", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Jump");
            rb.velocity = new Vector3(0, 2, 0);
        }
    }
}
