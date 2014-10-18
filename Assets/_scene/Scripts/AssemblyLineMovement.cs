using UnityEngine;
using System.Collections;

public class AssemblyLineMovement : MonoBehaviour {

	public float BeltSpeed;

	void OnCollisionStay2D(Collision2D coll) {
    	
		if (coll.gameObject.tag != "NotAffectedByConveyorBelt"	)
			coll.gameObject.rigidbody2D.velocity = new Vector2(-BeltSpeed,0);
			//coll.gameObject.rigidbody2D.AddForce(-Vector2.right * 10);
	}
}