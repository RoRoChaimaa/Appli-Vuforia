using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private GameController gameController;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "SpartanKing")
        {
            //print("Collision!");
            gameObject.SetActive(false);
            gameController = col.gameObject.GetComponent<GameController>();
            gameController.AddScore(1);
        }

        if (col.gameObject.name == "Ethan")
        {
            print("Collision!");
            gameObject.SetActive(false);
            gameController = col.gameObject.GetComponent<GameController>();
            gameController.AddScore(1);
        }

    }
   
    
}
