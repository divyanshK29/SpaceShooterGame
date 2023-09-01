using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    public static EndGameManager endManager;
    public bool gameOver;

    private PanelController panelController;
    private void Awake()
    {
        if (endManager == null)
        {
            endManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    public void StartResolveSequence()
    {
        StopCoroutine(nameof(ResolveSequence));
        StartCoroutine(ResolveSequence());

    }
    private IEnumerator ResolveSequence()
    {
        yield return new WaitForSeconds(2);
        ResolveGame();
    }
    public void ResolveGame()
    {
        if(gameOver==false)
        {
            WinGame();
        }
        else
        {
            LoseGame();
        }
    }
    public void WinGame()
    {
        panelController.ActiveWin();
    }
    public void LoseGame()
    {
        panelController.ActiveLose();
    }

    public void RegisterPanelController(PanelController pC)
    {
        panelController = pC;
    }


}
