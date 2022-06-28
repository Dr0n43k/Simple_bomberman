using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill_player : MonoBehaviour
{
    public GameObject enemy;
    void OnCollisionEnter(Collision collision)
    {
    }
     void Start()
    {
       enemy = (GameObject)this.gameObject;
    }
}
