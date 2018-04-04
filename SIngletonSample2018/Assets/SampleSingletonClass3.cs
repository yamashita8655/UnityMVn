using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingletonClass3 : BestPracticeSingleton<SampleSingletonClass3> {
	public int IntParameter;
	public string StringParameter;
	public bool BoolParameter;
	
	public void Initialize() {
	}
	
	public void DisplayParameter() {
		Debug.Log(IntParameter.ToString());
		Debug.Log(StringParameter);
		Debug.Log(BoolParameter);
	}
}
