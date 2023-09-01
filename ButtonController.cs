using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonController : MonoBehaviour
{
   public void LoadLevelString(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }

    public void LoadLevelInt(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
    }
}
