using UnityEngine;
using System.Collections;

public class camerazoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if( Input.GetAxis( "Mouse ScrollWheel" ) > 0 )
        {
            GetComponent<Camera>().orthographicSize--;
        }

        if( Input.GetAxis( "Mouse ScrollWheel" ) < 0 )
        {
            GetComponent<Camera>().orthographicSize++;
        }


	}
}

