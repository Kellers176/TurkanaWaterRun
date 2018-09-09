using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenTransitionScript : MonoBehaviour {

    public static screenTransitionScript instance;

    Animator anim;
    public GameObject player;

    string transitionScene;

    // Use this for initialization
    void Start ()
    {
        anim = gameObject.GetComponent<Animator>();
        instance = this;
	}
	
	void TransitionStart()
    {
        if (player != null)
        {
            // makes it so that the player cannot move

            // makes it so that the player starts out the scene holding the water jug
        }
    }

	void FadeIn ()
    {
        // makes it so that the player can move again

        anim.SetBool("fadeIn", true);
    }

    public void FadeOut(string nextScene)
    {
        // makes it so that the player cannot move

        transitionScene = nextScene;

        anim.SetBool("fadeIn", false);
    }

    void NextScene()
    {
        SceneManager.LoadScene(transitionScene);
    }

}
