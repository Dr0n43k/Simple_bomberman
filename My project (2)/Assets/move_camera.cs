using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    public GameObject player;
    public int speedRotation = 3;
    public int speed = 5;
    public GameObject[] objects;
    private bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
    }
    private void OnCollisionEnter(Collision collision)
    {
        on = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        on = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && on == false)
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S)&& on == false)
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && on == false)
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && on == false)
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
   
    }
}
