using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void FollowPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, 0.5f * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Player>().Damage(10);
        }
    }
}
