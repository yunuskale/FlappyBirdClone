using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject obstacle, bird;
    [SerializeField] private UiManager uiManager;
    private int score;
    public static bool started;

    public void StartGame()
    {
        InvokeRepeating("CloneObstacle", 0, 3f);
        uiManager.StartGame();
        Instantiate(bird);
        started = true;
    }
    public void GameOver()
    {
        uiManager.EndScoreText(score);
        uiManager.GameOver();
        CancelInvoke();
        started = false;
    }
    public void Score()
    {
        uiManager.ScoreText(++score);
    }
    private void CloneObstacle()
    {
        float r = Random.Range(-2f,3f);
        Instantiate(obstacle, new Vector2(4f,r), Quaternion.identity);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
