﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour {

	public GameObject igaguriPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			GameObject igaguri =
				Instantiate(igaguriPrefab) as GameObject;
			igaguri.GetComponent<IgaguriController>().Shoot(
				new Vector3(0, 200, 2000));
		}
	}
}
