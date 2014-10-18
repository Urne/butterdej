using UnityEngine;
using System.Collections;

public class BearSpawn : MonoBehaviour {
    
    public GameObject bear;
    bool canSpawn = true;
    public float spawnCooldown = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("b") && canSpawn)
        {
            Instantiate(bear);
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
