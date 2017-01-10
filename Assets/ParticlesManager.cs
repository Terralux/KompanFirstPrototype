using UnityEngine;
using System.Collections;

public class ParticlesManager : MonoBehaviour {

	public ParticleSystem[] particleSystems;

	[Range(4, 8)]
	public float minDelay = 0.1f;
	[Range(8.1f, 14f)]
	public float maxDelay = 5.1f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < particleSystems.Length; i++) {
			particleSystems [i].Stop ();
		}

		StartCoroutine (NextParticleSetup ());
	}

	IEnumerator NextParticleSetup(){
		yield return new WaitForSeconds (Random.Range (minDelay, maxDelay));

		int curIndex = Random.Range (0, particleSystems.Length);

		for (int i = 0; i < particleSystems.Length; i++) {
			if (curIndex == i) {
				particleSystems [i].Play ();
			} else {
				particleSystems [i].Stop ();
			}
		}

		StartCoroutine (NextParticleSetup ());
	}
}
