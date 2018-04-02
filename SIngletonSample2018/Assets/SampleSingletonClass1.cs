using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingletonClass1 : SimpleSingleton<SampleSingletonClass1> {
	int Count = 0;
	public void Initialize() {
		Debug.Log(Count.ToString());
		Count++;
	}
}
