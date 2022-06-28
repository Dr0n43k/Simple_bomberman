using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//finish position -15.41056
public class player_logic : MonoBehaviour
{

    public float time_exp = 20;
    public GameObject player;
    public GameObject[] objects;
    private GameObject bomb;
    private GameObject explosive1;
    private GameObject explosive2;
    private bool q = false;
    float start_time = 1000000000000000000;
    public Rigidbody rb;
    public int speed = 3;
    public bool on = false;
    float start_time1 = 1000000000000000000;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
        rb = GetComponent<Rigidbody>();
        
    }
    private void OnDestroy()
    {
        SceneManager.LoadScene(1);
    }
    
    
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(player);
        }
            on = true;
    }
    // Update is called once per frame
    void Update()
    {
        //print(Time.time - start_time);
        //print(Time.time - start_time1);
        //print(Time.time);
        float x = player.transform.position.x;
        float y = player.transform.position.y;
        float z = player.transform.position.z;
        float xb = 0;
        float yb = 0;
        float zb = 0;
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0.1f, speed);
            player.transform.eulerAngles = new Vector3(0f, 180f, 0f);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0.1f, -speed);
            player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, 0.1f, 0);
            player.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, 0.1f, 0);
            player.transform.eulerAngles = new Vector3(0f, 270f, 0f);
        }
        if (Input.GetKey(KeyCode.Space)&& q == false)
        {
            q = true;
            bomb = Instantiate(objects[0], objects[0].transform.localPosition = new Vector3(x,y,z), Quaternion.identity) as GameObject;
            
            start_time = Time.time;
        }
        if (Time.time - start_time >= time_exp&& q == true&& Time.time - start_time <= time_exp+1f)
        {
            xb = bomb.transform.position.x;
            yb = bomb.transform.position.y;
            zb = bomb.transform.position.z;
            explosive1 = Instantiate(objects[1], objects[1].transform.localPosition = new Vector3(xb, yb, zb), Quaternion.identity) as GameObject;
            explosive2 = Instantiate(objects[2], objects[2].transform.localPosition = new Vector3(xb, yb, zb), Quaternion.identity) as GameObject;
            explosive1.transform.localScale = new Vector3(3, 0.4f, 0.4f);
            explosive2.transform.localScale = new Vector3(0.4f, 0.4f, 3);
            Destroy(bomb);
            start_time = 0;
            start_time1 = Time.time;
            q = false;
            
        }
        if (Time.time - start_time1 >= 1f && Time.time - start_time1 <= 2f)
        {
            Destroy(explosive1);
            Destroy(explosive2);
            q = false;
            start_time1 = 0;
        }

    }

}
