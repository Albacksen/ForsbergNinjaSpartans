using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public WeaponCollision killzone;
	// Use this for initialization
	void Start () {
	
	}

	public void Attack(){
		killzone = gameObject.GetComponentInChildren<WeaponCollision>();
		if(killzone.in_enemy){
			killzone.DestroyEnemy();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
