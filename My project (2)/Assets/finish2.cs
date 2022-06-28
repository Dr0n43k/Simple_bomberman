using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject finish_obj;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        Application.LoadLevel(1);
    }
 

    void Start()
    {
        finish_obj = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


