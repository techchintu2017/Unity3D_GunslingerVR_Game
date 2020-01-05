using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public AudioClip audioClip;

    //public AudioSource audioSource;

    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //audioSource.PlayOneShot();
        //if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space"))
        if (Input.GetButton("Fire1"))
        {
            //GetComponent<AudioSource>().PlayOneShot(audioClip);
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.forward , out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.GetComponent<Bottle>())
                {
                    hit.transform.GetComponent<Bottle>().OnHit(150, transform.forward);
                }
            }
        }
    }
}
