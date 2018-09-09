using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour {
    //how far wraptuck can move away from camera before it follows
    public float xCharRange = 1.0f;

    //smoothing of Camera movement
    public float xTrackSmooth = 10.0f;

    //boundaries our camera can move in x axis
    public Vector2 maxXLevel;
    public Vector2 minXLevel;

    //hold our Camera Track Point Transform
    public Transform cameraTrackPoint;
    
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        TrackPlayer();
	}

    //getting the distance our character is away from the cmaera 
    bool CheckXCharRange()
    {
        return Mathf.Abs(transform.position.x - cameraTrackPoint.position.x) > (xCharRange);
    }

    //Camera tracking main action
    void TrackPlayer()
    {
        //variable to store the positional information of our player camers
        float targetX = transform.position.x;

        //if character is out of range then move the camera to follow character until in range again
        if(CheckXCharRange() )
        {
            targetX = Mathf.Lerp(transform.position.x, cameraTrackPoint.position.x, xTrackSmooth * Time.deltaTime);
        }

        //clamp our cameras range of movement
        targetX = Mathf.Clamp(targetX, minXLevel.x, maxXLevel.x);

        //Move our Camera after all calculations are done above
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
    }

}
