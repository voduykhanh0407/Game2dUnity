using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerScrips : MonoBehaviour
{
    public static int Sc = 1;
    public static double lf = 1;
    public static int id = 1;
    public static int highScore = 1;
    public void Update()
    {
        Sc = Score.coinAmount;
        lf = Life.life;
        id = CharacterSelection.idCharacter;
        highScore = HightScore.hightscore;
    }
}