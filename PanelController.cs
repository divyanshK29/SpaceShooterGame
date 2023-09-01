using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private CanvasGroup cGroup;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;
    void Start()
    {
        EndGameManager.endManager.RegisterPanelController(this);
    }
    public void ActiveWin()
    {
        cGroup.alpha = 1;
        winScreen.SetActive(true);
    }

    public void ActiveLose()
    {
        cGroup.alpha = 1;
        loseScreen.SetActive(true);
    }

}
