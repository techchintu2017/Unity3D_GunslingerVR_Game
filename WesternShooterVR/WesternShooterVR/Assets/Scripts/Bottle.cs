using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public bool wasHit;

    //public GameObject[] models;

    void Start()
    {
        // int randomIndex = randomIndex.Range (0, models.Length);

        // for (int i = 0; i < models.Length; i++)
        // {
        //     models [i].SetActive (i == randomIndex);
        // }
    }

    void Update()
    {
        
    }

    public void OnHit(float hitForce, Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(hitForce * direction);
        wasHit = true;
    }
}
