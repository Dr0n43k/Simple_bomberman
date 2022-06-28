using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_logic : MonoBehaviour
{

    public Transform player;
    public float move_speed;
    public float rotation_speed;
    public Transform enemy;
    public Rigidbody rb;
    public bool on = false;
    void OnCollisionEnter(Collision collision)
    {
        
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (on == true)
        {
            var look_dir = player.position - enemy.position;
            look_dir.y = 0;
            enemy.rotation = Quaternion.Slerp(enemy.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
            rb.AddForce(transform.forward);
        }
    }
}

