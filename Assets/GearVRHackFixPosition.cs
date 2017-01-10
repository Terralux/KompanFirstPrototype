using UnityEngine;
using System.Collections;

public class GearVRHackFixPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = Vector3.zero;
		StartCoroutine (ResetPosition ());
	}

	IEnumerator ResetPosition(){
		yield return new WaitForSeconds (1f);
		transform.position = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
