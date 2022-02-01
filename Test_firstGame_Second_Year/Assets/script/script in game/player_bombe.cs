using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bombe : MonoBehaviour
{
    public GameObject Bombe;
    void Update()
    {
        if (GameObject.FindWithTag("Bombe") != null)
        {
            
        }    
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject go = Instantiate(Bombe, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity) as GameObject;
                go.transform.parent = GameObject.Find("Player").transform;
            }
        }
    }
}
