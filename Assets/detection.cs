using UnityEngine;
using System.Collections;

public class detection : MonoBehaviour {

	public bool detect = false;


	public Transform interactable = null;
	public Transform interactable1 = null;


	// Use this for initialization
	void Start () {
	
	}


	void Update () {


}

	void OnTriggerEnter(Collider interactable) {
		detect = true;
		Application.Quit();
		print("I SEE YOU");
	}

	void OnTriggerEnter1(Collider interactable1) {


		detect = true;
		Application.Quit();
		print("I SEE YOU");
	}
}