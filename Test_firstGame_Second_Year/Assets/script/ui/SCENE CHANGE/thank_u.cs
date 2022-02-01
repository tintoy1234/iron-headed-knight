using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thank_u : MonoBehaviour
{
    public GameObject canvas;
    private void Start()
    {
        canvas.SetActive(false);
    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "thank_u")
        {
            Debug.Log("hit");
            canvas.SetActive(true);
            Cursor.visible = true;
        }
    }
}
