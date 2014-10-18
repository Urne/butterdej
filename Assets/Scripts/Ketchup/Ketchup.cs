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
        if(coll.gameObject.tag == "ground")
        {
            print("hello");
            Instantiate(ketchupFloor, new Vector2(this.transform.position.x, coll.transform.position.y + coll.transform.lossyScale.y + 0.1f), this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
