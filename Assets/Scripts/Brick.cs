using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick: MonoBehaviour
{

    public float health = 70f;
    void OnCollisionEnter2D(Collision2D target)
    {

        if (target.gameObject.GetComponent<Rigidbody2D>() == null)
            return;

        float damage = target.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10f;

        if (damage > 30)
            

        health -= damage;

        if (health <= 0)
            Destroy(gameObject);
    }
}

