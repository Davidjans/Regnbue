


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    PlayMovement player;
    Transform target;
    Vector3 dir;
    float bullet_speed = 26;
    void Start()
    {
        target = GameObject.Find("target").transform;
        player = FindObjectOfType<PlayMovement>();
        dir = (target.position - transform.position).normalized;
    }

    void Update()
    {
        //bullet move
        transform.position += dir * (bullet_speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ice")
        {
            other.gameObject.GetComponent<Ice>().Melt();
            Destroy(gameObject);
        }
    }
}
