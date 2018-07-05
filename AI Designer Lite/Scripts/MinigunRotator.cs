using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigunRotator : MonoBehaviour {

	public bool canRotate = false;
	public float speed = 5;
	public AIDesigner.TargetController targetController;

	
	void Start(){
		if (targetController == null){
			Debug.Log("YOUR MINIGUN ROTATOR DOES NOT HAVE ASSIGNED TARGET CONTROLLER!");
			canRotate = false;
		} else {
			canRotate = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (canRotate && targetController.canRangedAttack){
 			DoRotate();
		}
	}

	public void DoRotate(){
		 transform.Rotate(new Vector3(0,0,5) * Time.deltaTime * speed);			
	}
}
