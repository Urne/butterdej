﻿using UnityEngine;
using System.Collections;

public class DogHandler : MonoBehaviour {

    GameObject player; 
    public float speedMultiplier = 0;
    public float timeToJump = 0;
    bool isJumping = false;
    Vector2 directionVector;

	// Use this for initialization
	void Start () {
	    player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if(!isJumping)
        {
            print("Jumping");
            isJumping = true;
            directionVector = player.transform.position - transform.position;
            directionVector = new Vector2(directionVector.x * (1/Mathf.Abs(directionVector.x)), 1);
            rigidbody2D.AddForce(directionVector.normalized * speedMultiplier);
        }
        //if(
        
        
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "ground")
        {
            StartCoroutine("waitForJump");
        }
    }


    IEnumerator waitForJump()
    {
        print("Coroutiner started");
        yield return new WaitForSeconds(timeToJump);
        isJumping = false;
        print("laters");
    }
}
