using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerContinue : MonoBehaviour {

    // Use this for initialization
    //public GameObject panel;
    //public TextMeshProUGUI currentText;
    public waterJugScript myJug;
    public GameObject objectToDeactivate;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (myJug.hasWater == true)
        {
            objectToDeactivate.SetActive(false);
            //Debug.Log(myJug.getWater());            
        }
        else if(myJug.hasWater == false)
        {
            objectToDeactivate.SetActive(true);
        }
       
    }

  

}
