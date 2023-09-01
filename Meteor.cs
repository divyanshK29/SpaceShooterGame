using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : Enemy

{
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private float speed;
    [SerializeField] private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        rb.velocity=Vector2.down*speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotateSpeed*Time.deltaTime);
    }
    public override void HurtSequence()
    {
       
    }

    public override void DeathSequence()
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D otherColl)
    {
        if(otherColl.CompareTag("Player"))
        {
            //Destroy(otherColl.gameObject); it will destroy the player, we can rather damage it on collison with enemy.
            PlayerStats player = otherColl.GetComponent<PlayerStats>();
            player.PlayerTakeDamage(damage);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
