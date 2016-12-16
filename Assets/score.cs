using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public Text scoreText;

	public static int scoreing;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		scoreText.text = scoreing.ToString();
	
		if (scoreing == 4000) 
		{

			Application.Quit();

		}
	}
}
