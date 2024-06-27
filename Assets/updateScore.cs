using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class updateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public GameObject gameOverScreen;

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }


    public void increaseScore()
    {

        Debug.Log("increase score function is running");
        score++;
        scoreText.text = score.ToString();
        Debug.Log(score);


    }
    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);





    }
}
