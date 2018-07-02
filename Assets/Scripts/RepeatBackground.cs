using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {

    private BoxCollider2D groudCollider;
    private float groundLength;

	// Use this for initialization
	void Start ()
    {
        groudCollider = GetComponent<BoxCollider2D>();
        groundLength = groudCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > groundLength)
        {
            RollingBackground();
        }
	}

    void RollingBackground()
    {
        Vector2 groundOffset = new Vector2(- groundLength * 2, 0);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
