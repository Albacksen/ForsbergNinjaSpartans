using UnityEngine;
using System.Collections;

public class Killzone : MonoBehaviour {

	public bool in_enemy = false;
	
	public Archer current_collider; // Need not be public
	// Use this for initialization
	void Start () {
	
	}

	public void DestroyEnemy(){ // Requires current_collider to be not null
		if (current_collider != null){
			Destroy(current_collider.gameObject);
			current_collider = null;
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Enemy"){
			in_enemy = true;
			current_collider = collider.GetComponent<Archer>();
		}
	}
	void OnTriggerExit(Collider collider) // Sämst. This is NOT the correct way to do this
	{
		if (collider.tag == "Enemy"){
			in_enemy = false;
			current_collider = null;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
