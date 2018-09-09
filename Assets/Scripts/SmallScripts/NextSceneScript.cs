using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour {

    public string nextScene;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if (col.gameObject.GetComponent<waterJugScript>().getWater())
            {
                screenTransitionScript.instance.FadeOut(nextScene);
            }
        }

    }
}
