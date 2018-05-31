using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {

	private HingeJoint myHingeJoint;

	private float defaulAngle = 20;
	private float flickAngle = -20;

	// Use this for initialization
	void Start () {
		this.myHingeJoint = GetComponent<HingeJoint>();

		SetAngle(this.defaulAngle);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag"){
			SetAngle (this.flickAngle);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}

		if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.defaulAngle);
		}
		if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.defaulAngle);
		}
	}

	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
				jointSpr.targetPosition = angle;
				this.myHingeJoint.spring = jointSpr;
	}
}