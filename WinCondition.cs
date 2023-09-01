using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private float timer;
    [SerializeField] private float possivleWinTime;
    [SerializeField] private GameObject[] spawner;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > possivleWinTime)
        {
            for(int i=0; i<spawner.Length; i++)
            {
                spawner[i].SetActive(false);
            }
            EndGameManager.endManager.StartResolveSequence();
            gameObject.SetActive(false);

            //create a function that will check if the player survived the last spammed enemy/meteor. Display Win/Lose using GAME MANAGER.

        }
    }
}
