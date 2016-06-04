﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//[SerializeField]
	public GameObject m_archerPrefab;
	public Archer m_archerPrefab2;
	public Player Player1;
	public Player Player2;

	public float EnemyRespawnTimeInterval;
	public Vector3 EnemySpawnPoint;
	float m_EnemyRespawnCooldown = 0f;


	// Use this for initialization
	void Start () {
	
	}

	void SpawnEnemy () {
		var enemy = (Archer) Instantiate(m_archerPrefab2, EnemySpawnPoint, Quaternion.identity);
		enemy.Init(Player1, Player2);
	}

	// Update is called once per frame
	void Update () {
		if (m_EnemyRespawnCooldown < 0f){
			SpawnEnemy();
			m_EnemyRespawnCooldown = EnemyRespawnTimeInterval;
		}


		m_EnemyRespawnCooldown -= Time.deltaTime;
	}
}