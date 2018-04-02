using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Execute : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SampleSingletonClass1.Instance.Initialize();
		SampleSingletonClass1.Instance.Initialize();
		
		SampleSingletonClass2.Instance.Initialize();
		SampleSingletonClass2.Instance.Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
