using UnityEngine;
using System.Collections;

public class fling : MonoBehaviour {
	public KeyCode Key = KeyCode.LeftArrow;
	private float angle;
	void Start(){
		angle = GetComponent<HingeJoint> ().spring.targetPosition;
		rigidbody.centerOfMass = Vector3.zero;
	}


	void FixedUpdate () {
		var spring = GetComponent<HingeJoint> ().spring;
		if (Input.GetKey (Key)) {
			spring.targetPosition = -angle;
		}/*else if (Input.GetKey (KeyCode.RightArrow)){
			spring.targetPosition = -angle;
		}*/else{
			spring.targetPosition = angle;
		}
		GetComponent<HingeJoint> ().spring = spring;
	}
}
