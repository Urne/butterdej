using UnityEngine;
using System.Collections;

public class PlayerObjectPickUp : MonoBehaviour {

	public int girlWeight = 0;
	public int MaxFatness = 5;

	void Update()
	{
		if(girlWeight >= MaxFatness)
		Destroy(gameObject.GetComponent<HingeJoint2D>());
	}


	void OnCollisionEnter2D(Collision2D coll) {
		print ("lol");

		if(coll.gameObject.tag == "Burger")
		{
			girlWeight ++;
			Destroy(coll.gameObject);
			
			
			//coll.gameObject.rigidbody2D.velocity = new Vector2(0, 0);
		}

		if(coll.gameObject.name != "BeltMaster" && coll.gameObject.name != "Main Camera" && coll.gameObject.tag != "testing")
		{
			//
			print(coll.gameObject.name);
			//Destroy(coll.gameObject);
			//girlWeight++;
			//print (girlWeight);


			//coll.gameObject.rigidbody2D.velocity = new Vector2(0, 0);
		}

	}  
}
