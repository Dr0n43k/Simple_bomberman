using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies_script : MonoBehaviour
{

    
    GameObject enemy;
    public GameObject[] objects;
    GameObject enemy1;
    GameObject enemy2;
    GameObject enemy3;
    public float time34;
    float start_time3;
    public bool on2;
    void Awake()
    {
        start_time3 = Time.time;
        time34 = 5f;
        on2 = false;
    }

    void Start()
    {
        enemy = (GameObject)this.gameObject;
        float x = enemy.transform.position.x;
        float y = enemy.transform.position.y;
        float z = enemy.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.time - time34);
        if (Time.time - start_time3 >= time34 && Time.time - start_time3<=time34+1)
        {
            int randomNumber = Random.Range(0, 3);
            print(randomNumber);
            if (randomNumber == 1 && on2 == false)
            {
                on2 = true;
                Instantiate(objects[0],new Vector3(-7.59f, 0.634f, -1.31f), Quaternion.identity);
                start_time3 = Time.time;
                randomNumber = 0;
                on2 = false;
            }
            else if (randomNumber == 2 && on2 == false)
            {
                on2 = true;
                Instantiate(objects[0],new Vector3(-11.29f, 0.41f, 3.34f), Quaternion.identity);
                start_time3 = Time.time;
                randomNumber = 0;
                on2 = false;
            }
            else if (randomNumber == 3 && on2 == false)
            {
                on2 = true;
                Instantiate(objects[0], new Vector3(-7.59f, 0.634f, 4.45f), Quaternion.identity);
                start_time3 = Time.time;
                randomNumber = 0;
                on2 = false;
            }
 

        }
    }
}
