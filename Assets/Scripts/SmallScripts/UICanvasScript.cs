using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvasScript : MonoBehaviour {

	public Button continueButton;
	public Text uiText;
	// put array holder in

	void Start () {
		Button bt = continueButton.GetComponent<Button> ();
		bt.onClick.AddListener (Continue);
	}
	void Update(){
		if (Input.GetMouseButtonDown (1)) {
			InputText ();
		}
	}
	
	public void InputText(/* put input type here (string array? */){
		uiText.text = "_"; // replace "-" with array input;
		continueButton.interactable = true;
	}

	void Continue(){
		//uiText.text = 'next in array'
		//if (done){
		continueButton.interactable = false;
		uiText.text = "";
	}
}
