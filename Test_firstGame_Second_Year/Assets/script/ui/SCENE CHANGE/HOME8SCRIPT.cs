using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HOME8SCRIPT : MonoBehaviour
{
    public void Q()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
        Debug.Log(Time.timeScale);
    }
}
