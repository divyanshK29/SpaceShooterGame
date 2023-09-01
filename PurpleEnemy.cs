using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleEnemy : Enemy
{
    [SerializeField] private float speed;
    private float shootTimer = 0;
    [SerializeField] private float shootInterval;


    [SerializeField] private Transform leftCanon;
    [SerializeField] private Transform rightCanon;

    [SerializeField] private GameObject bulletPrefab;
    void Start()
    {
        rb.velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if(shootTimer >= shootInterval)
        {
            Instantiate(bulletPrefab, leftCanon.position, Quaternion.identity);
            Instantiate(bulletPrefab, rightCanon.position, Quaternion.identity);
            shootTimer = 0;  
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerStats>().PlayerTakeDamage(damage);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    public override void HurtSequence()
    {
        anim.SetTrigger("Damage");
    }
    public override void DeathSequence()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
