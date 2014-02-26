using UnityEngine;
using System.Collections;

public class bouncer : MonoBehaviour {
	public float force = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision){
		var direction = collision.transform.position - transform.position;
		direction.Normalize ();
		direction *= force;
		collision.rigidbody.AddForce( direction, ForceMode.VelocityChange);
	}
}
