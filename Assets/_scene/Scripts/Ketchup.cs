using UnityEngine;
using System.Collections;

public class Ketchup : MonoBehaviour {

	public GameObject ketchup;

	public bool canShoot = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("l" )&& canShoot == true){
			//canShoot = false;
			GameObject penis = (GameObject)Instantiate(ketchup, transform.position, Quaternion.identity);
			print ("shoots");
		}

	}

}
