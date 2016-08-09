using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	[Tooltip("Array of game object: 'Enemy'")]
	public GameObject[] enemies;

	//the current amount of enemies on screen
	[Tooltip("Current amount of enemier")]
	public int amount;

	[Tooltip("Max no. of enemies that appear in the same time")]
	public int maxEnemy;

	[Tooltip("Boundary of X-cor that an enemy appear")]
	public int minX = -8;
	[Tooltip("Boundary of X-cor that an enemy appear")]
	public int maxX = 8;
	[Tooltip("Boundary of Z-cor that an enemy appear")]
	public int minZ = -2;
	[Tooltip("Boundary of Z-cor that an enemy appear")]
	public int maxZ = 2;

	private Vector3 spawnPoint;
	
	// Update is called once per frame
	void Update () {
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		amount = enemies.Length;

		if (amount < maxEnemy) {
			InvokeRepeating ("spawnEnemy", Random.Range(2, 10), 0f);
		}
	}

	void spawnEnemy() {
		spawnPoint.x = Random.Range (minX, maxX);
		spawnPoint.y = 0.5f;
		spawnPoint.z = Random.Range (minZ, maxZ);
	
		Instantiate(Resources.Load("Enemy_Prefab"), spawnPoint, Quaternion.identity);
		CancelInvoke();

	}
}
