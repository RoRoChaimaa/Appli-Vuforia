using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingAnimation : MonoBehaviour
{

    //Animations du perso
    Animation animations;
    //vitesse de deplacement 
    public float walkSpeed;
    public float runSpeed;
    public float turnSpeed;

    // inputs
    public string inputLeft;
    public string inputRight;
    public string inputBack;
    public string inputFront;

    public Vector3 jumpSpeed;



    void Start()
    {
        //print("I'm in start");
        animations = gameObject.GetComponent<Animation>();
    }

    void Update()
    {
        //si on avance
        if (Input.GetKey(inputFront) && !Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, walkSpeed * Time.deltaTime);
            animations.Play("walk");
        }
        //si on recule
        if (Input.GetKey(inputBack))
        {
            transform.Translate(0, 0, -(walkSpeed / 2) * Time.deltaTime);
            animations.Play("walk");
        }
        //rotation a gauche
        if (Input.GetKey(inputRight))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }
        //rotation a droite
        if (Input.GetKey(inputLeft))
        {
            transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        }
        //si on sprint 
        if (Input.GetKey(inputFront) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(0, 0, runSpeed * Time.deltaTime);
            animations.Play("run");
        }
        // respirer
        if (!Input.GetKey(inputFront) && !Input.GetKey(inputBack))
        {
            animations.Play("idle");
        }
        // sauter
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    print("jump");
        //    // preparation des sauts
        //    Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
        //    v.y = jumpSpeed.y;
        //    gameObject.GetComponent<Rigidbody>().velocity = jumpSpeed;
        //}
    }
}
