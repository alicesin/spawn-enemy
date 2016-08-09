using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public Transform track;
	public GameObject track_obj;
	private float moveSpeed = 3f;

	public float speed;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		track_obj = GameObject.Find("Track");
		track = track_obj.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -10 || transform.position.x > 10 || transform.position.y < -10) {
			Destroy(gameObject);
		} else {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			// y = 0.0f, becoz dun want it move up/down
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			//transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);

			float move = moveSpeed * Time.deltaTime;
			transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
			transform.position = Vector3.MoveTowards(transform.position, track.position, move);

			rb.AddForce (movement * speed);
		}
	}
}
