using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] protected Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
    }

    public virtual void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, 1f * Time.deltaTime);
    }
    public void Damage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
}
