using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_logic : MonoBehaviour
{
    public GameObject Bomb;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Undestroy") 
        Destroy(other.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        Bomb = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
  
    }
}
