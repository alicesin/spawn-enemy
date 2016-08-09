using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject[] enemies;

	//the current amount of enemies on screen
	public int amount;

	private Vector3 spawnPoint;

	//private Gameobject Enemy = GameObject.Find("Enemy_Prefab");
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if (amount < 10) {
			InvokeRepeating ("spawnEnemy", Random.Range(2, 10), 0f);
		}
	}

	void spawnEnemy() {
		spawnPoint.x = Random.Range (-8, 8);
		spawnPoint.y = 0.5f;
		spawnPoint.z = Random.Range (-2, 2);
	
		Instantiate(Resources.Load("Enemy_Prefab"), spawnPoint, Quaternion.identity);
		CancelInvoke();

	}
}
