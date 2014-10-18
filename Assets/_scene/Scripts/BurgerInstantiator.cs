using UnityEngine;
using System.Collections;

public class BurgerInstantiator : MonoBehaviour {

	public GameObject Burger;
	private bool canRun = true;
	private float randomInterval;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine(WaitAndPrint(Random.Range(20.0F, 70.0F)));
		if(canRun == true)
		{
			//randomInterval = (Random.Range(
				StartCoroutine(WaitAndPrint(Random.Range(4.0F, 10.0F)));
		
		}

	}

	
	IEnumerator WaitAndPrint(float waitTime) {
		canRun = false;
		yield return new WaitForSeconds(waitTime);
		Instantiate(Burger, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
		canRun = true;
	}
}
