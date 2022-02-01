using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tuto_scenemanagement : MonoBehaviour
{
    public GameObject canvas;
    private void Start()
    {
        canvas.SetActive(false);
    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "tuto")
        {
            Debug.Log("hit");
            canvas.SetActive(true);
            SceneManager.LoadScene(2);
        }
    }
}
