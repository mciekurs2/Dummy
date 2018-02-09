using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFallingPeople : MonoBehaviour {

	[SerializeField]
	private Transform respawnTransform;

	private void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("Catched "+collider.gameObject.name);

		GameObject catchedObject = collider.gameObject;

		if (catchedObject.tag == "Player") {
			catchedObject.transform.position = respawnTransform.position;
		}
	}
}
