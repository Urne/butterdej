using UnityEngine;
using System.Collections;

public class DestroyOnPlayerCollison : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D coll) {

		if(coll.gameObject.tag == "Player")
		{
			Destroy(gameObject);

			//få det til at virke på player mass variablen i stedet
			//coll.gameObject.GetComponent<PlayerObjectPickUp>().girlWeight ++;
			//Destroy(other.gameObject);
			//print (coll.gameObject.GetComponent<PlayerObjectPickUp>().girlWeight);
		}
	}  
}
