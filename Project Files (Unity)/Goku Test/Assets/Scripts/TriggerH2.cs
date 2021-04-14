using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerH2 : MonoBehaviour
{
    public GameObject Activate;
    public GameObject OuchRender;

    // Start is called before the first frame update
    private void Start()
    {
        OuchRender.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hitbox1")
        {
            Debug.Log("Ouch");
            StartCoroutine(Waiting());
        }

    }

    IEnumerator Waiting()
    {
        OuchRender.SetActive(true);
        yield return new WaitForSeconds(1f);
        OuchRender.SetActive(false);
    }

}
