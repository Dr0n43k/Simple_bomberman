using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_logic : MonoBehaviour
{
    public GameObject Wall;
    public int endurance = 50;
   
    // Start is called before the first frame update
    void Start()
    {
        Wall = (GameObject)this.gameObject;
    }
    private void OnTriggerEnter(Collider other)
    {
        endurance -= 20;
        if (endurance <= 0)
            Destroy(Wall);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
