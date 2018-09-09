using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManagerScript : MonoBehaviour {
	public Text dialogueT;
	bool talking = false;
	bool done = false;
	int currentTextNum;

	public string[] Leader;
	public string[] Mother;
	public string[] readyToLeave;
	public string[] getYourJug;
	public string[] traveller1;
	public string[] traveller2;
	public string[] traveller3;

	public string[] tempArray;

	public Text continueText;
	public Image[] textPanel;

	void Start(){
		continueText.enabled = false;
		foreach (Image img in textPanel) {
			img.enabled = false;
		}
		dialogueT.enabled = false;
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (talking) {
				if (!done) {
					Next ();
				} else {
					CloseDialogue ();
				}
			}
		}
	}

	public void InputDialogue(string name){
		if (name == "Leader") {
			tempArray = Leader;
		} else if (name == "Mother") {
			tempArray = Mother;
		} else if (name == "readyToLeave") {
			tempArray = readyToLeave;
		} else if (name == "getYourJug") {
			tempArray = getYourJug;
		} else if (name == "traveller1") {
			tempArray = traveller1;
		} else if (name == "traveller2") {
			tempArray = traveller2;		
		} else if (name == "traveller3") {
			tempArray = traveller3;
		}
		StartDialogue ();
	}

	void StartDialogue(){
		continueText.enabled = true;
		foreach (Image img in textPanel) {
			img.enabled = true;
		}
		talking = true;
		done = false;
		dialogueT.enabled = true;
		dialogueT.text =  tempArray[0];
		currentTextNum++;
	}

	void Next(){
		if (currentTextNum == tempArray.Length) {
			done = true;
			CloseDialogue ();
		} else {
			dialogueT.text = tempArray [currentTextNum];
			currentTextNum++;
		}
	}

	public void CloseDialogue(){
		continueText.enabled = false;
		foreach (Image img in textPanel) {
			img.enabled = false;
		}
		dialogueT.enabled = false;
		talking = false;
		currentTextNum = 0;
	}

}
