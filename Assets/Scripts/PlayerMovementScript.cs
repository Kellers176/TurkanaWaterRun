using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
	SpriteRenderer sr;

	public GameObject scaler;
    bool shouldMove = false;
    public GameObject player;
    Vector3 mousePos;
    public float moveSpeed = 0.15f;
    //The position you clicked
    private Vector2 target;
    //That position relative to the players current position (what direction and how far did you click?)
    public Vector2 relativePosition;
    public float scaleNumber = 1;

    public Vector2 speed = new Vector2(5f, 2f);
    // 2 - Store the movement
    private Vector2 movement;


    // Use this for initialization
    void Start()
    {
        target = transform.position;
        //player.transform.localScale = new Vector3(0.5f, 0.5f, 1);
    }
    // Update is called once per frame
    void Update()
    {
            float horizontal = Input.GetAxis("Horizontal");
            if (Input.GetMouseButtonDown(0) && shouldMove)
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               Flip(horizontal);
            }
        relativePosition = new Vector2(target.x - gameObject.transform.position.x, target.y - gameObject.transform.position.y);
        shouldMove = false;
        
        

    }
    public void setSpeed(float speed)
    {
        moveSpeed = speed;
    }

    void FixedUpdate()
    {

        // 5 - If you are about to overshoot the target, reduce velocity to that distance
        //      Else cap the Movement by a maximum speed per direction (x then y)
        if (speed.x * Time.deltaTime >= Mathf.Abs(relativePosition.x))
        {
            movement.x = relativePosition.x;
        }
        else
        {
            movement.x = speed.x * Mathf.Sign(relativePosition.x);
        }
        if (speed.y * Time.deltaTime >= Mathf.Abs(relativePosition.y))
        {
            movement.y = relativePosition.y;
        }
        else
        {
            movement.y = speed.y * Mathf.Sign(relativePosition.y);
        }

        // 6 - Move the game object using the physics engine
        player.GetComponent<Rigidbody2D>().velocity = movement * moveSpeed;
    }

    public void setMove(bool myMove)
    {
        shouldMove = myMove;
    }

    private void Flip(float horizontal)
    {
        Vector3 theScale = transform.localScale;
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        float WorldXPos = Camera.main.ScreenToWorldPoint(pos).x;

        if (WorldXPos > gameObject.transform.position.x)
        {
            theScale.x = scaleNumber;
            transform.localScale = theScale;
        }
        else
        {
            theScale.x = -scaleNumber;
            transform.localScale = theScale;
        }
    }

}
