using UnityEngine;
using System.Collections;

public class HammerMovement : MonoBehaviour {

	private Vector2 startPos;
	// Use this for initialization
	void Start () {
	
		startPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
		print (startPos);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			print("space key was pressed");
			rigidbody2D.gravityScale = 40;
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		
		if (coll.gameObject.tag == "assemblyLine"	){
			rigidbody2D.gravityScale = 0;
			rigidbody2D.velocity = new Vector2(0,0);
			//rigidbody2D.angularVelocity = 0;
			print ("yay");
			Example ();

		}
	}

	//void moveHammerBack

	IEnumerator Example() {
		print(Time.time);
		yield return new WaitForSeconds(5);
		print(Time.time);
	}

}
