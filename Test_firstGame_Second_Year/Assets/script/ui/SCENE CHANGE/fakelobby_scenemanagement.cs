using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fakelobby_scenemanagement : MonoBehaviour
{
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "fake")
        {
            Debug.Log("hit");
            SceneManager.LoadScene(3);
        }
    }
}
