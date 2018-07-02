using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject GameOverText;
    public bool GameOver = false;
    public static GameController instance;
    public float ScrollSpeed = 1.5f;
    public Text ScoreText;





    private int score = 0;
	// Use this for initialization
	void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (GameOver == true && (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("Restart : " + SceneManager.GetActiveScene().name);
            //也可以用buildIndex读取当前关卡
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    public void PlaneDied()
    {
        GameOverText.SetActive(true);
        GameOver = true;
    }
    public void GameScore()
    {
        if (GameOver == true)
        {
            return;
        }
        score++;
        ScoreText.text = "SCORE:" + score.ToString();
    }
}
