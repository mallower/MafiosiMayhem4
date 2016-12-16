using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {



    public int time;

    public Transform interactable = null;
    public Transform Character = null;

    // Use this for initialization
    void Start () {

		score.scoreing = 0;

	}
	
	// Update is called once per frame
	void Update () {
        



    }

    void OnMouseDown()
    {
        print("Box Clicked!");

    }

    void OnTriggerStay(Collider Character)
    {
		
        time += 1;



        if(time == 100)
        {
			score.scoreing += 500;
            Destroy(interactable.gameObject);

        }
    }


}
