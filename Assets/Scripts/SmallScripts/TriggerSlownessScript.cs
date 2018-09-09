using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSlownessScript : MonoBehaviour {

    public GameObject slowingPlayerObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            //kill me
            slowingPlayerObject.SetActive(true);
        }
    }
}
