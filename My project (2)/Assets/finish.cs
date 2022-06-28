using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    private void OnDestroy()
    {
        SceneManager.LoadScene(2);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player")
            Destroy(this.gameObject);
    }

}
