using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopColliders : MonoBehaviour {
    public GameObject myThing1;
    public GameObject myThing2;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "EnemyLook")
        {
            myThing1.SetActive(false);
       
        }
        if (col.tag == "EnemyLook2")
        {
            myThing2.SetActive(false);

        }
    }
 
}
