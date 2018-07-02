using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateColunms : MonoBehaviour {

    public GameObject Column;
    public Transform ColumnBornPoint;
    public float ColumnRate = 4;
    public static GameController instance;


    private Rigidbody2D newColumn;
    private Vector3 bornPoint;
    private float nextColumn = 0;
    private bool isDead = false;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (isDead == false)
        {

            if ( Time.time > nextColumn) 
        {
            nextColumn = Time.time + ColumnRate;
            float   tem_y = ColumnBornPoint.transform.position.y + Random.Range(-1.0f, 1.0f);
            if (tem_y > 2.0f)
                {
                    tem_y = -0.5f;
                }
            if (tem_y < -3.0f)
                {
                    tem_y = 0.5f;
                }

            Instantiate(Column, new Vector3(ColumnBornPoint.transform.position.x, tem_y, ColumnBornPoint.transform.position.z), Quaternion.identity);
        }

        }
    }
}
//+Random.Range(-10.0f,10.0f)
//(GameController.instance.GameOver = false) &&