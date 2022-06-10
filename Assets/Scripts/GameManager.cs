using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isGameOver;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public GameObject mainMenuPanel;



    public int score = 0;

    public PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        // scoreText.text = score.ToString() + " POINTS";
    }

    public void AddPoint()
    //public void UpdateScore(int pointToAdd)
    {
        score += 1;
        // scoreText.text = score.ToString() + " POINTS";
        

        // score += pointToAdd;
        // scoreText.text = ("Score: {score}");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Money"))
        {
            score += 1;
            Debug.Log("score");
        }
    }

    // Update is called once per frame
    void Update()
    {

        // scoreText.text = ("score");
        // Debug.Log("score");

        /*
        if (PlayerControllerScript.MaxHP <= 0)
        {
            isGameOver = true;
        }
        */
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        // score = 0;
        // AddPoint(0);
        // Debug.Log("score");
    }
}
