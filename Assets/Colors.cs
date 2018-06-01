using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
  float timer;
	// Update is called once per frame
	void Update () {
    timer -= Time.deltaTime;
    if (timer < 0)
    {
      GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
      timer = 3;
    }
	}
}
