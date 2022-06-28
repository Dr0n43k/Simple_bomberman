using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont_destroy : MonoBehaviour
{ public GameObject place;
    // Start is called before the first frame update
    void Start()
    {
        place = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(place);
    }
}
