using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry_script : MonoBehaviour
{
    public GameObject canvas;
    public void Q()
    {
        canvas.SetActive(false);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
    }
}
