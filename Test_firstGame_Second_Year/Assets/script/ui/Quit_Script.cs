using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_Script : MonoBehaviour
{
    public void Q()
    {
        Application.Quit();
        Debug.Log("tu as quitter le jeu");
    }
}
