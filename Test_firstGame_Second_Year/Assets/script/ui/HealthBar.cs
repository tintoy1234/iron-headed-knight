using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{ 
public Image HealthBarUI;
    // Update is called once per frame
    void Update()
    {
        Vector3 Bar = Camera.main.WorldToScreenPoint(this.transform.position);
        HealthBarUI.transform.position = Bar;
    }
}
