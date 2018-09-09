using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonScript : MonoBehaviour {
	
	Button bt;

	void Start () {
		bt = gameObject.GetComponent<Button> ();
		bt.onClick.AddListener (StartGame);
	}
	

	void StartGame(){
        screenTransitionScript.instance.FadeOut("mainScene");
	}
}
