using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {

	public GameObject cube;
	Vector3 targetPosition;

	void Start () 
    {
		targetPosition = transform.position;
	}


	void Update(){
 
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
 
			if (Physics.Raycast(ray, out hit))
            {
				targetPosition = hit.point;
                cube.transform.position = Vector3.Lerp( transform.position, targetPosition, 1);
			}
		         }
	}
}