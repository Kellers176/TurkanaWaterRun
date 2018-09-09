using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartColliders : MonoBehaviour
{
    public GameObject myThing1;
    public GameObject myThing2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
         myThing1.SetActive(true);
         myThing2.SetActive(true);
        //col.gameObject.SetActive(true);
    }

}