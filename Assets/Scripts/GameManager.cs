using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//[SerializeField]
	public Archer archerPrefab;
	public Player Player1;
	public Player Player2;

	public float EnemyRespawnTimeInterval;
	public Vector3 EnemySpawnPoint;
	float m_EnemyRespawnCooldown = 0f;

	// Use this for initialization
	void Start () {
	}

	void SpawnEnemy () {
		var enemy = (Archer) Instantiate(archerPrefab, EnemySpawnPoint, Quaternion.identity);
		enemy.Init(Player1, Player2);
	}

	void DeleteEnemy(Archer archer) {
		Destroy(archer.gameObject);
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