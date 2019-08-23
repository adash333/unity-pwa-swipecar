using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI部品を使用するために必要

public class GameDirector : MonoBehaviour {

	GameObject car; 
	GameObject flag;
	GameObject distance;

	// Use this for initialization
	void Start () {
		this.car = GameObject.Find ("car"); // このように記載することでプロジェクト内のcarオブジェクトを見つけることができる
		this.flag = GameObject.Find("flag");
		this.distance = GameObject.Find("Distance");
	}
	
	// Update is called once per frame
	void Update () {
		float length = this.flag.transform.position.x - this.car.transform.position.x;

		if (length >= 0) {
			this.distance.GetComponent<Text> ().text = "ゴールまで" + length.ToString ("F2") + "m";
		} else {
			this.distance.GetComponent<Text> ().text = "Game Over";
		}

	}

}
