using UnityEngine;
using System.Collections;

public class PlayerObjectPickUp : MonoBehaviour {

	public int girlWeight = 0;

	void OnCollisionEnter2D(Collision2D coll) {
		//print ("lol");
		if(coll.gameObject.name != "AssemblyLine" && coll.gameObject.name != "Main Camera" && coll.gameObject.tag != "testing")
		{
			//
			print(coll.gameObject.name);
			//girlWeight++;
			//print (girlWeight);


			//coll.gameObject.rigidbody2D.velocity = new Vector2(0, 0);
		}

	}  
}
