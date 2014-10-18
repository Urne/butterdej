using UnityEngine;
using System.Collections;

public class Ketchup : MonoBehaviour {

    public GameObject ketchupFloor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter2D(Collider2D coll)
    {
		print(coll.gameObject.name);
		if(coll.gameObject.tag == "assemblyLine")
        {
            print("hello");
            GameObject splash = (GameObject)Instantiate(ketchupFloor, new Vector2(this.transform.position.x, coll.transform.position.y), this.transform.rotation);
			splash.rigidbody2D.velocity = new Vector2( coll.gameObject.GetComponent<AssemblyLineMovement>().BeltSpeed ,splash.rigidbody2D.velocity.y);
			Destroy(this.gameObject);
        }
    }
}
