using UnityEngine;
using System.Collections;

public class HammerMovement : MonoBehaviour {

	private Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && transform.position == startPos){
				rigidbody2D.gravityScale = 40;
		}
			if (transform.position.y > startPos.y){
				rigidbody2D.gravityScale = 0;
				rigidbody2D.velocity = new Vector2(0,0);
				transform.position = startPos;
			}
		}

	IEnumerator WaitAndPrint(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		rigidbody2D.gravityScale = 0;
		rigidbody2D.velocity = new Vector2(0,5);
	}

	void OnCollisionEnter2D(Collision2D coll) {
		

	}

	void OnTriggerEnter2D(Collider2D coll) {

		if(coll.gameObject.name == "BeltMaster"){	
			StartCoroutine(WaitAndPrint(0.5F));
			print ("yay");
		}else if(coll.gameObject.name == "Player")
			Destroy(coll.gameObject);

		if (coll.gameObject.tag != "assemblyLine" && coll.gameObject.name != "MainCamera"){
			//rigidbody2D.gravityScale = 0;

			//coll.gameObject.rigidbody2D.mass = 0.1f;
			Destroy(coll.gameObject);
			//coll.gameObject.transform.position = new Vector3(0,0,0);

				
			}else if (coll.gameObject.tag == "assemblyLine")
			{
				StartCoroutine(WaitAndPrint(0.5F));
				rigidbody2D.velocity = new Vector2(0,0);
			}
		}

}
