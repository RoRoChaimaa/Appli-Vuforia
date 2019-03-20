using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {

    private Animator objAnimator;
    // Use this for initialization
    void Start()
    {
        objAnimator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            //objAnimator.SetTrigger("WalkRightTrigger");
            objAnimator.SetBool("WalkRightBool", true);
        }
        if (Input.GetKeyUp("right"))
        {
            //objAnimator.SetTrigger("WalkRightTrigger");
            objAnimator.SetBool("WalkRightBool", false);
        }


        if (Input.GetKeyDown("left"))
        {
            //objAnimator.SetTrigger("WalkRightTrigger");
            objAnimator.SetBool("WalkLeftBool", true);
        }
        if (Input.GetKeyUp("left"))
        {
            //objAnimator.SetTrigger("WalkLeftTrigger");
            objAnimator.SetBool("WalkLeftBool", false);
        }


        if (Input.GetKeyDown("up"))
        {
            //objAnimator.SetTrigger("WalkUpTrigger");
            objAnimator.SetBool("WalkForwardBool", true);
        }
        if (Input.GetKeyUp("up"))
        {
            //objAnimator.SetTrigger("WalkUpTrigger");
            objAnimator.SetBool("WalkForwardBool", false);
        }
    }
}
