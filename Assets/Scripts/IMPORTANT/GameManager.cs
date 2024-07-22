using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform PlayerPaddle;
    public Transform EnemyPaddle;
    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        PlayerPaddle.position = new Vector3(-7f, 0f, 0f);
        EnemyPaddle.position = new Vector3(7f, 0f, 0f);
        ballControler.ResetBall();

        PlayerScore = 0;
        EnemyScore = 0;

        textpointsPlayer.text = PlayerScore.ToString();
        TextPointsEnemys.text = EnemyScore.ToString();

        ScreenEndGame.SetActive(false);
    }

    public BallControler ballControler;

    public int PlayerScore = 0;
    public int EnemyScore = 0;

    public TextMeshProUGUI textpointsPlayer;
    public TextMeshProUGUI TextPointsEnemys;

    public GameObject ScreenEndGame;

    public void ScorePlayer()
    {
        PlayerScore++;
        textpointsPlayer.text = PlayerScore.ToString();
        CheckWin();
    }

    public void ScoreEnemy()
    {
        EnemyScore++;
        TextPointsEnemys.text = EnemyScore.ToString();
        CheckWin();
    }

    public int WinPoint = 2;

    public void CheckWin()
    {
        if (EnemyScore >= WinPoint || PlayerScore >= WinPoint)
        {
            //ResetGame();
            EndGame();
        }
    }

    public void EndGame()
    {
        ScreenEndGame.SetActive(true);
        string winner = SaveController.Instance.GetName(PlayerScore > EnemyScore);
        textEndGame.text = "Vitória " + winner;
        SaveController.Instance.SaveWinner(winner);
        Invoke("LoadMenu", 2f);
    }
    private void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public TextMeshProUGUI textEndGame;
    
    
}
