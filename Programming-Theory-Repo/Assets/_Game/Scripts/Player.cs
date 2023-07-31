using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float health=100;
    // Start is called before the first frame update
    void Start()
    {
        float inpuHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * inpuHorizontal * Time.deltaTime);
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
        
    }
}
