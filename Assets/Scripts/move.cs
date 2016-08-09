using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public Transform track;
	private float moveSpeed = 3f;
	
	// Update is called once per frame
	void Update () {
		
		float move = moveSpeed * Time.deltaTime;
		transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
		transform.position = Vector3.MoveTowards(transform.position, track.position, move);
	}
}
