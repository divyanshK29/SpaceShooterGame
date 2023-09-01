using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    private float health;
    [SerializeField] private Image healthFill;
    [SerializeField] private GameObject explosionPrefab;
    void Start()
    {
        health = maxHealth;
        healthFill.fillAmount = health / maxHealth;
    }

    public void PlayerTakeDamage(float damage)
    {
        health -= damage;
        healthFill.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            EndGameManager.endManager.gameOver = true;
            EndGameManager.endManager.StartResolveSequence();
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    

    
}
