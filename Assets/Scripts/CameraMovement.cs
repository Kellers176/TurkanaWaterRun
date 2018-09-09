using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform trigger;
    public Transform camera1;
    bool isLerp;
    float speed = 0.6f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isLerp)
            PositionChanging();
		
	}

    void PositionChanging()
    {
        Vector3 pos = camera1.position;
        pos.x = Mathf.Lerp(pos.x, trigger.position.x + 5, Time.deltaTime * speed);
        camera1.position = pos;
        //camera1.transform.position = Vector2.Lerp(camera1.position, trigger.position, Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            isLerp = true;
        }
    }
}
