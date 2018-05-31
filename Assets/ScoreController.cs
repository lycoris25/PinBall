using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	public GameObject scoreText;

	private int score = 0;

	public void Score(int point){
		this.score += point;
		scoreText.GetComponent<Text>().text = score.ToString();
	}


	// Use this for initialization
	void Start () {

		this.scoreText = GameObject.Find ("ScoreText");

	}
		
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other){

		Debug.Log (other.gameObject.tag);

		if (other.gameObject.tag == "SmallStarTag"){
			Score(10);
		}else if(other.gameObject.tag == "LargeStarTag"){
			Score(30);
		}else if(other.gameObject.tag == "SmallCloudTag"){
			Score(20);
		}else if(other.gameObject.tag == "LargeCloudTag"){
			Score(50);
		}

     }
}