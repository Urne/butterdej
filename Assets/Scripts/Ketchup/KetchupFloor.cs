using UnityEngine;
using System.Collections;

public class KetchupFloor : MonoBehaviour {

	public float secondsIncapacitated = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll)
	{

		if(coll.gameObject.tag == "Player")
		{
			StartCoroutine(DenyWalk(coll.gameObject));
		}
	}

	IEnumerator DenyWalk(GameObject gameobject)
	{
		gameobject.GetComponent<PlayerMovement>().canMove = false;
		gameobject.GetComponent<PlayerMovement>().goBack = true;
		gameobject.GetComponent<Animator>().SetBool("Falling", true);
		yield return new WaitForSeconds(secondsIncapacitated);
		gameobject.GetComponent<Animator>().SetBool("Falling", false);
		gameobject.GetComponent<PlayerMovement>().canMove = true;
		gameobject.GetComponent<PlayerMovement>().goBack = false;

	}
}
