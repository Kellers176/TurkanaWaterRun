using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemoveTextScript : MonoBehaviour {

    public TextMeshProUGUI myText;

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
            myText.enabled = false;
        }
    }
}
