using UnityEngine;
using System.Collections;

public class screenOpacity : MonoBehaviour {

	public GameObject player;
	public bool hide = true;
	MasterBear controller;
	public AudioClip death;
	bool playing = false;
	// Use this for initialization
	void Start () {
		controller = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MasterBear>();
	}
	
	// Update is called once per frame
	void Update () {




		if(player == null)
			hide = false;

		if(hide == false)
		{
			controller.gameEnd = true;
			if(gameObject.name == "deathscreen" && !playing)
			{
				playing = true;
				AudioSource.PlayClipAtPoint(death, gameObject.transform.position);
			}
			renderer.material.color = new Color(1, 1, 1, 1);
		}else{
			renderer.material.color = new Color(1, 1, 1, 0);
		}

		if(Input.GetKeyDown("space") && !hide)
		{
			Application.LoadLevel("FinalScene");
		}
		
	}


}

