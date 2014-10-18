using UnityEngine;
using System.Collections;

public class ketchupKlat : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("klat started");
		transform.localScale = new Vector3(transform.localScale.x/3, transform.localScale.y, transform.localScale.z);
	}

	void OnCollisionEnter2D(Collision2D coll) {

		print ("klat collision");
		transform.localScale = new Vector3(1,1,1);

	}  
}
