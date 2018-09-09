using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCharacterScript : MonoBehaviour {

    public float scale;
    public GameObject player;
    public PlayerMovementScript mplayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "ScaleCollider")
        {
            mplayer.scaleNumber = scale;
            player.transform.localScale = new Vector3(scale, scale, 1);
            //StartCoroutine(Scale());
        }
    }

    IEnumerator Scale()
    {
        float timer = 0;
        Vector3 originalScale = player.transform.localScale;
        Vector3 destinationScale = new Vector3(scale, scale, scale);

        do
        {
            player.transform.localScale = Vector3.Lerp(originalScale, destinationScale, timer / 1.0f);
            timer += Time.deltaTime;
            yield return null;
        } while (timer <= 1.0f);
            
    }

}
