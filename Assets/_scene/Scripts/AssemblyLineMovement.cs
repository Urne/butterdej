using UnityEngine;
using System.Collections;

public class AssemblyLineMovement : MonoBehaviour {

	void OnCollisionStay2D(Collision2D coll) {
    	
		if (coll.gameObject.tag != "NotAffectedByConveyorBelt"	)
			coll.gameObject.rigidbody2D.velocity = new Vector2(-4,0);
			//coll.gameObject.rigidbody2D.AddForce(-Vector2.right * 10);
	}
}