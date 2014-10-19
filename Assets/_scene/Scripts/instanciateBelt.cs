using UnityEngine;
using System.Collections;

//IS NOT USED

public class instanciateBelt : MonoBehaviour {
	
	public int beltLength;
		
	public GameObject beltSection;


	private float offsetX = 0.8f;
	public float offsetY;


	private float currentX;
	private float currentY;

	void Start() {
		//transform.position = transform.parent.position;
		//Ugly fix due to orientation of belt relative to movement direction :/
		currentX = transform.position.x +(beltLength*offsetX);

		currentY = transform.position.y;

		for (int i = 0; i <= beltLength; i++) {
			/*
			GameObject penis = (GameObject)Instantiate(beltSection, new Vector3(currentX, currentY, 0), Quaternion.identity);
			penis.transform.parent= transform;
			penis.transform.localScale = new Vector3(penis.transform.localScale.x, penis.transform.localScale.y , Random.value*20);
			penis.rigidbody2D.velocity = new Vector2(-5,0);
			//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				//cube.AddComponent<Rigidbody>();
				//cube.transform.position = new Vector3(0, 0, 0);
*/
			currentX = currentX - offsetX;
		}
	}
}

