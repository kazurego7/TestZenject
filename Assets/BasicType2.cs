using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BasicType2 : MonoBehaviour {
	[Inject] INonMono _nonMono;
	// Use this for initialization
	void Start () {
		switch (_nonMono) {
			case NonMono2 msg:
				Debug.Log (msg);
				break;
		}
	}

	// Update is called once per frame
	void Update () { }
}