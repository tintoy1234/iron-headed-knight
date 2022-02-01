using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_canvas : MonoBehaviour
{
	public GameObject canvasObject;

    private void Start()
    {
		canvasObject.SetActive(false);
    }
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale != 0)
		{
			Time.timeScale = 0;
			canvasObject.SetActive(true);
			Cursor.visible = true;
		}
		else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
		{
			Time.timeScale = 1;
			canvasObject.SetActive(false);
			Cursor.visible = false;
		}
	}
}
