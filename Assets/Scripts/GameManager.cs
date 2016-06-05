using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//[SerializeField]
	public Archer archerPrefab;
	public Player Player1;
	public Player Player2;

	public float EnemyRespawnTimeIntervalMin;
	public float EnemyRespawnTimeIntervalMax;

	float m_EnemyRespawnCooldown = 0f;

	// Use this for initialization
	void Start () {
	}

	void SpawnEnemy (Vector3 enemySpawnPoint) {
		var enemy = (Archer) Instantiate(archerPrefab, enemySpawnPoint, Quaternion.identity);
		enemy.Init(Player1, Player2);
	}

	void DeleteEnemy(Archer archer) {
		Destroy(archer.gameObject);
	}

	// Update is called once per frame
	void Update () {
		if (m_EnemyRespawnCooldown < 0f){
			Vector3 enemySpawnPoint = RandomSpawnPoint();
			Debug.Log("Enemy spawn point" + enemySpawnPoint);
			SpawnEnemy(enemySpawnPoint);
			float new_spawn_time = Random.Range(EnemyRespawnTimeIntervalMin, EnemyRespawnTimeIntervalMax);
			m_EnemyRespawnCooldown = new_spawn_time;
		}

		m_EnemyRespawnCooldown -= Time.deltaTime;
	}

	Vector3 RandomSpawnPoint(){
		float x_value;
		if (Random.value > 0.5f){
			x_value = Random.Range(-20, -10);
		}
		else{
			x_value = Random.Range(10, 20);
		}
		float z_value = Random.Range(5, 15);
		return new Vector3(x_value, 0, z_value);
	}
}