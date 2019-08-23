using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

	GameObject car; 

	// Use this for initialization
	void Start () {
		this.car = GameObject.Find ("car");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		Debug.Log ("Clicked");

		// transformを取得
		Transform myTransform = this.car.transform;

		// World座標を基準に、座標を取得
		Vector2 worldPos = myTransform.position;
		worldPos.x = -2.8f;
		worldPos.y = -2.9f;
		myTransform.position = worldPos;
	}
}
