using UnityEngine;
using System.Collections;

public class Beltinstantiator : MonoBehaviour {
	public int beltLength;
	
	public GameObject beltSection;
	public GameObject roller;
	
	private float offsetX = 0.8f;
	public float offsetToRoller;
	
	
	private float currentX;
	private float currentY;
	
	void Start() {
		//transform.position = transform.parent.position;
		//Ugly fix due to orientation of belt relative to movement direction :/
		currentX = transform.position.x +(beltLength*offsetX);
		
		currentY = transform.position.y;
		
		for (int i = 0; i <= beltLength; i++) {
			
			Instantiate(beltSection, new Vector3(currentX, currentY, 0), Quaternion.identity);
			//if(i%2 == 0)
			Instantiate(roller, new Vector3(currentX, currentY-offsetToRoller, 0), Quaternion.identity);
			//penis.rigidbody2D.velocity = new Vector2(-5,0);
			//GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			//cube.AddComponent<Rigidbody>();
			//cube.transform.position = new Vector3(0, 0, 0);
			
			currentX = currentX - offsetX;
		}
	}
}
