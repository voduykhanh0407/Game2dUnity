using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSave : MonoBehaviour
{

    public void Save()
    {
        ES2.Save(SceneManager.GetActiveScene().name, "savedScene");

        ES2.Save(managerScrips.lf, "life");
        ES2.Save(managerScrips.Sc, "score");
        ES2.Save(managerScrips.id, "ID");
        ES2.Save(managerScrips.highScore, "hight");
    }
}
