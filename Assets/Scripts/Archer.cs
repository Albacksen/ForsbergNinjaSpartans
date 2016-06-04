using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Archer : MonoBehaviour {

	public Player player1;
	public Player player2;

	public GameObject arrow;

	public float movementSpeed;

	float m_cooldown = 0f;

	// Use this for initialization
	void Start () {
	
	}

	public void Init(Player m_player1, Player m_player2){
		player1 = m_player1;
		player2 = m_player2;
	}		

	Vector3 playerDirection(){
		float player1_distance = (player1.transform.position - transform.position).magnitude;
		float player2_distance = (player2.transform.position - transform.position).magnitude;
		Player closest_player;
		if (player1_distance < player2_distance){
			closest_player = player1;
		}
		else{
			closest_player = player2;
		}
		Vector3 directionVector = (closest_player.transform.position - transform.position).normalized;
		return directionVector;
	}


	// Update is called once per frame
	void Update () {
		transform.position += playerDirection() * movementSpeed;
	}
}
