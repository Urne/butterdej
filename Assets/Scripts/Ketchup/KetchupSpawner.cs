using UnityEngine;
using System.Collections;

public class KetchupSpawner : MonoBehaviour {


    public GameObject ketchup;
    bool canSpawn = true;
    public float spawnCooldown = 0;
	public AudioClip sound;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("l") && canSpawn)
        {
			AudioSource.PlayClipAtPoint(sound, gameObject.transform.position);
            GameObject ketchupInstance = (GameObject)Instantiate(ketchup, new Vector2(this.transform.position.x, this.transform.position.y-3.5f), this.transform.rotation);
            ketchupInstance.rigidbody2D.AddForce(-Vector2.up);
            canSpawn = false;
            StartCoroutine("WaitForSpawn");
        }	
	}

    IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(spawnCooldown);
        canSpawn = true;
    }
}
