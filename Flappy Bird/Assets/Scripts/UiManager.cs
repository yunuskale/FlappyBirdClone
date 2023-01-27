using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject starting, gameOver, game;
    [SerializeField] private TextMeshProUGUI scoreText, endScoreText, bestScoreText;

    public void StartGame()
    {
        starting.SetActive(false);
        game.SetActive(true);
    }

    public void GameOver()
    {
        game.SetActive(false);
        gameOver.SetActive(true);
    }
    public void ScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
    public void EndScoreText(int score)
    {
        endScoreText.text = score.ToString();
        if(score > PlayerPrefs.GetInt("bestScore", 0))
        {
            PlayerPrefs.SetInt("bestScore", score);
        }
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();

    }
}
