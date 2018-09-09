using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class waterJugScript : MonoBehaviour {

    public PlayerMovementScript player;

    public bool waterGrabbed;
    public RaycastHit2D waterHit;
    public float distance = 0.5f;
    public Transform waterPoint;
    public float throwForce;
    public LayerMask notGrabbed;
    public Transform dropPoint;
    public bool hasWater;
    public bool hasBeenFilled;

    // Use this for initialization
    void Start()
    {

    }

    public bool getWater()
    {
        return hasWater;
    }

    public void remoteGrab()
    {
        waterGrabbed = true;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //change to click
        {
            if (!waterGrabbed)
            {
                if(hasBeenFilled == true)
                {
                    player.moveSpeed = 0.8f;
                }
                Physics2D.queriesStartInColliders = false;
                waterHit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, distance);

                
                if (waterHit.collider != null && waterHit.collider.tag == "WaterJug")
                {
                    waterGrabbed = true;

                }
                //grab
            }
            else if (!Physics2D.OverlapPoint(waterPoint.position, notGrabbed))
            {
                waterGrabbed = false;
                hasWater = false;
                if(hasBeenFilled == true)
                {
                    player.moveSpeed = 1.0f;
                }
               // Debug.Log("Player:" + hasWater);
                if (waterHit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
                {
                    //waterHit.collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x +3, -2) * throwForce;
                    waterHit.collider.gameObject.transform.position = dropPoint.position;
                    hasWater = false;
                }
                //throw
            }
        }
        if (waterGrabbed)
        {
            waterHit.collider.gameObject.transform.position = waterPoint.position;
            hasWater = true;
        }

    }

}

