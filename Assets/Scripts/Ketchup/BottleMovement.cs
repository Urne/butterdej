using UnityEngine;
using System.Collections;

public class BottleMovement : MonoBehaviour {

	public float bottleMinX = 0;
	public float bottleMaxX = 0;
	public float speed = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetAxis("HorKetchup") != 0)
		{
			if(Input.GetAxis("HorKetchup") < 0 && transform.position.x > bottleMinX)
			{
				transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
			}

			if(Input.GetAxis("HorKetchup") > 0 && transform.position.x < bottleMaxX)
			{
				transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
			}
		}

	}
}
