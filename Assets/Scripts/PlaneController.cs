using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

    public float UpForce = 200f;
    public AudioSource Flap;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, UpForce));
                anim.SetTrigger("Flap");
                Flap.Play();
            }
        }
	}

    void  OnCollisionEnter2D(Collision2D other)
    {
        isDead = true;
        anim.SetTrigger("Die");
        GameController.instance.PlaneDied();
        rb2d.velocity = Vector2.zero;
    }
}
