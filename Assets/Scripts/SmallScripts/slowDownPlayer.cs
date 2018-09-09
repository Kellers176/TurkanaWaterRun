using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowDownPlayer : MonoBehaviour {


    public PlayerMovementScript player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            player.setSpeed(0.5f);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.setSpeed(1.0f);
    }
}
