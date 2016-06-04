using UnityEngine;
using System.Collections;

public class WeaponCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void DestroySoon(){
		// Add code for waiting a second or issuing an animation
		Destroy(gameObject);
	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Killzone"){
    		print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
    		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
   			print("Their relative velocity is " + collisionInfo.relativeVelocity);
   			DestroySoon();
   		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
