using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingletonClass2 : SimpleMonoBehaviourSingleton<SampleSingletonClass2> {
	int Count = 0;
	public void Initialize() {
		Debug.Log(Count.ToString());
		Count++;
	}
}
