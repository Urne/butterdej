using UnityEngine;
using System.Collections;

public class BearSpawn : MonoBehaviour {
    
	public GameObject master;
    public GameObject bear;
    //bool canSpawn = true;
    //public float spawnCooldown = 0;
	public string control;
	public AudioClip growl;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(control) && master.GetComponent<MasterBear>().canSpawn == true)
        {
			AudioSource.PlayClipAtPoint(growl, gameObject.transform.position);
            Instantiate(bear, transform.position, transform.rotation);
            
			master.GetComponent<MasterBear>().respawn();
			//canSpawn = false;
            //StartCoroutine("WaitForSpawn");
        }
	}

   /* IEnumerator WaitForSpawn()
    {
        yield return new WaitForSeconds(spawnCooldown);
        canSpawn = true;
    }*/
}
