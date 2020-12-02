using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleLoad : MonoBehaviour
{
    public string leveltoload;

    public void Load()
    {
        leveltoload = ES2.Load<string>("savedScene");
        SceneManager.LoadScene(leveltoload);

        Score.coinAmount = ES2.Load<int>("score");
        Life.life = ES2.Load<double>("life");
        CharacterSelection.idCharacter = ES2.Load<int>("ID");
    }
}
