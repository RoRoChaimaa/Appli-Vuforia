using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimation : MonoBehaviour {

    private Animator m_Animator;
    private bool scan = false;
    private bool idle = true;
   
    // Use this for initialization
    void Start () {
        m_Animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Scanning");
            //scan = !scan;
            //m_Animator.SetBool("IsFacingObject", scan);
            m_Animator.SetBool("IsFacingObject", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Resetting");
            //scan = false;
            //m_Animator.SetBool("IsFacingObject", scan);
            m_Animator.SetBool("IsFacingObject", false);

        }
    }
}
