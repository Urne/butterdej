using UnityEngine;
using System.Collections;

public class cubeAnimation : MonoBehaviour {



	// Use this for initialization
	void Start () {
		//rigidbody.velocity = new Vector2(-10, 0);
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x < -20)
			transform.position = new Vector2(10,transform.position.y);
	}
}
