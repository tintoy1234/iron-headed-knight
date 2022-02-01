using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_sword : MonoBehaviour
{
    public GameObject sword;
    void Update()
    {
        sword.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FindObjectOfType<AudioManager>().Play("Spear");
        }
    }
    private void OnTriggerStay(Collider hit)
    {
            if (hit.transform.tag == "Enemy")
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    FindObjectOfType<AudioManager>().Play("Spear");
                    Destroy(hit.gameObject);
                }

            }
    }
    private void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Enemy")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                FindObjectOfType<AudioManager>().Play("Spear");
                Destroy(hit.gameObject);
            }

        }
    }
}
