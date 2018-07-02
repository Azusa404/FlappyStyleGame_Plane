using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colimns : MonoBehaviour {


    void Update()
    {
        GameObject.Destroy(gameObject, 20.0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            GameController.instance.GameScore();
    }
}
 