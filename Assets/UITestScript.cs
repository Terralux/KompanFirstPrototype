using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UITestScript : MonoBehaviour {

	public InputField myUsername;
	public InputField myPassword;

	private string myCorrectUsername = "Light";
	private string myCorrectPassword = "Terralux";

	public GameObject loginPanel;
	public GameObject menuPanel;

	public Image myImage;

	void Awake(){
		menuPanel.SetActive (false);
		loginPanel.SetActive (true);
	}

	public void CheckInput(){
		bool correctLogin = true;
		if (myUsername.text == myCorrectUsername) {
			Debug.Log ("My Username was right! :D");
		} else {
			correctLogin = false;
			Debug.Log ("I suck at logins!");
		}

		if (myPassword.text == myCorrectPassword) {
			Debug.Log ("My Password was right! :D");
		} else {
			correctLogin = false;
			Debug.Log ("I suck at logins!");
		}

		if (correctLogin) {
			StartCoroutine (myCorountine ());
		} else {
			StopAllCoroutines ();
		}
	}

	IEnumerator myCorountine(){
		yield return new WaitForSeconds (2.0f);
		Debug.Log ("I logged in!");
		menuPanel.SetActive (true);
		loginPanel.SetActive (false);
		StopAllCoroutines ();
	}

}
