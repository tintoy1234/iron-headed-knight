using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class niveau1_scenemanagement : MonoBehaviour
{
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "niveau1")
        {
            Debug.Log("hit");
            SceneManager.LoadScene(4);
        }
    }
}
