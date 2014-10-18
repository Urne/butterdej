using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    
    public float maxSpeed = 0;
    public float speedMultiplier = 0;
    public float jumpMultiplier = 0;
    public float stopMultiplier = 0;
    bool isJumping = false;


	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKeyDown("w") && !isJumping)
        {
            isJumping = true;
            rigidbody2D.AddForce(Vector2.up * jumpMultiplier);
        }

        if((Input.GetAxis("Horizontal") != 0))
        {
            
            if(Input.GetAxis("Horizontal") < 0 && rigidbody2D.velocity.x > (-1 * maxSpeed))
            {

                rigidbody2D.AddForce(Vector2.right * speedMultiplier * Input.GetAxis("Horizontal"));
            }
            else if(Input.GetAxis("Horizontal") > 0 && rigidbody2D.velocity.x < (maxSpeed))
            {
                rigidbody2D.AddForce(Vector2.right * speedMultiplier * Input.GetAxis("Horizontal"));
            }

        }
        else
        {
            if(rigidbody2D.velocity.x != 0 && !isJumping)
            {
                rigidbody2D.velocity = new Vector2((rigidbody2D.velocity.x / 100) * stopMultiplier, rigidbody2D.velocity.y);
            }
        
        
        }
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
        isJumping = false;
    }













}
