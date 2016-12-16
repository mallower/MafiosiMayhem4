// Patrol.cs
using UnityEngine;
using System.Collections;


public class Patrol : MonoBehaviour {

	public Transform[] points;
	private int destPoint = 0;
	private NavMeshAgent agent;

	public Transform Sight;

	public bool CanSee;

	float Range = 400.0f;

	public Transform Target;

	void Start () {
		agent = GetComponent<NavMeshAgent>();

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;

		GotoNextPoint();
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.
		agent.destination = points[destPoint].position;

		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}


	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (agent.remainingDistance < 0.5f)
			GotoNextPoint();

		Sight.transform.LookAt(Target);

		if(Physics.Raycast(Sight.transform.position, Sight.transform.forward, Range))

		{

			CanSee = false;

		}

		else {

			CanSee = true;

		}

	}



	}
