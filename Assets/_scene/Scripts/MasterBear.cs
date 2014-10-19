using UnityEngine;
using System.Collections;

public class MasterBear : MonoBehaviour {

	public bool gameEnd = false;
	public bool canSpawn = true;
	public float spawnCooldown = 0;
	bool playing = false;
	public AudioClip fabric;

	AudioSource source;
	// Use this for initialization
	void Start () {
		source = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(0);
		}


		if(gameEnd && !playing)
		{
			source.clip = fabric;
			source.Play ();
			playing = true;
		}


		//if(canSpawn == false)
			//StartCoroutine("WaitForSpawn");
	
	}

	public void respawn()
	{
		canSpawn = false;
		StartCoroutine("WaitForSpawn");
	}


	IEnumerator WaitForSpawn()
	{
		yield return new WaitForSeconds(spawnCooldown);
			canSpawn = true;
	}
}
