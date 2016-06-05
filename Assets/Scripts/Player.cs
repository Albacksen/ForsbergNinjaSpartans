using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Killzone killzone;
	// Use this for initialization
	void Start () {
	
	}

	public void Attack(){
		killzone = gameObject.GetComponentInChildren<Killzone>();
		if(killzone.in_enemy){
			killzone.DestroyEnemy();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
