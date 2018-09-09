using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpWaterScript : MonoBehaviour {

    public waterJugScript player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "WaterJug")
        {

            player.hasBeenFilled = true;

        }
    }
}
