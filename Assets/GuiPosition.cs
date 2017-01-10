using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GuiPosition : MonoBehaviour {

	public int index = 0;
	public Text myText;

	void Update(){
		myText.text = transform.position.ToString();
	}

}
