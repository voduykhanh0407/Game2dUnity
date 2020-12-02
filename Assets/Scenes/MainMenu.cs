using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        HightScore.hightscore = ES2.Load<int>("hight");
    }
    public void PlayGame()
    {
        Score.coinAmount = 0;
        Life.life = 2;
        Score.lifeAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }

    public void Shop()
    {
        SceneManager.LoadScene(1);
    }
}
