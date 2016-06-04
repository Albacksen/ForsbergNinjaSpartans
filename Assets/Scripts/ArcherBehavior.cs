using UnityEngine;
using System.Collections;

public class ArcherBehavior : MonoBehaviour {

	public Player player1;

	public Transform arrow;

	float m_cooldown = 0f;

	// Use this for initialization
	void Start () {
	
	}

	Vector3 player1Direction(){
		Vector3 directionVector;
		directionVector = (player1.transform.position - transform.position).normalized;
		return directionVector;
	}

	void spawnArrow(){
		Instantiate(arrow, transform.position, Quaternion.identity);
		//new_arrow.position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(player1Direction());
		//Debug.Log(transform.rotation);
		transform.position += Vector3.left * 0.1f;
		if (m_cooldown < 0f){
			Debug.Log(player1Direction());
			spawnArrow();
			m_cooldown = 1f;
		}

		m_cooldown -= Time.deltaTime;
	}
}
