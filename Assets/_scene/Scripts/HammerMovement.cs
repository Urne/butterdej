using UnityEngine;
using System.Collections;

public class HammerMovement : MonoBehaviour {

	private Vector3 startPos;
	public float sleep = 2;
	private bool sleeping = false;
	private bool canKill = false;
	public float Cooldown;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("k") && transform.position == startPos && sleeping == false ){
				rigidbody2D.gravityScale = 40;
				canKill = true;
				sleeping = true;
			StartCoroutine(WakeUp(Cooldown));
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

	IEnumerator WakeUp(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		sleeping = false;
	}

	void OnCollisionEnter2D(Collision2D coll) {
		

	}

	void OnTriggerEnter2D(Collider2D coll) {

			if(coll.gameObject.name == "BeltMaster"){	
				//	StartCoroutine(WaitAndPrint(0.5F));
				print ("yay");
			}
			if (coll.gameObject.tag != "assemblyLine" && coll.gameObject.name != "MainCamera" && transform.position != startPos){
				//rigidbody2D.gravityScale = 0;

				//coll.gameObject.rigidbody2D.mass = 0.1f;
				Destroy(coll.gameObject);
				print("wtf");
				//coll.gameObject.transform.position = new Vector3(0,0,0);

					
			}else if (coll.gameObject.tag == "assemblyLine")
			{
				StartCoroutine(WaitAndPrint(0.5F));
				rigidbody2D.velocity = new Vector2(0,0);
				canKill = false;
			}
		}

}
