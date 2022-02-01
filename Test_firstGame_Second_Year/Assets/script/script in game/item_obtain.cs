using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_obtain : MonoBehaviour
{
    public GameObject chest;
    public GameObject enemy;

    public GameObject sword;

    public GameObject player_S;
    public GameObject player_B;
    public GameObject bombe;
    player_sword PS;
    player_bombe PB;
    Bombe_script BS;

    public GameObject bombe_slot1;
    public GameObject bombe_slot2;
    public GameObject sword_slot1;
    public GameObject sword_slot2;

    void Start()
    {
        PS = player_S.GetComponent<player_sword>();
        PB = player_B.GetComponent<player_bombe>();
        BS = bombe.GetComponent<Bombe_script>();
        PS.enabled = false;
        PB.enabled = false;
        BS.enabled = false;
        bombe_slot2.SetActive(false);
        bombe_slot1.SetActive(false);
        sword_slot1.SetActive(false);
        sword_slot2.SetActive(false);
    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "Chest1")
        {
            if (Input.GetKey(KeyCode.E))
            {
                PB.enabled = true;
                BS.enabled = true;
                bombe_slot1.SetActive(true);
            }
        }
        if (hit.transform.tag == "Chest2")
        {
            if (Input.GetKey(KeyCode.E))
            {
                PS.enabled = true;
                PB.enabled = false;
                BS.enabled = false;
                bombe_slot1.SetActive(false);
                bombe_slot2.SetActive(true);
                sword_slot1.SetActive(true);
            }
        }
    }
    void Update()
    {
        if (PS.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                FindObjectOfType<AudioManager>().Play("Switch");
                Debug.Log("switch_bombe");
                PS.enabled = false;
                PB.enabled = true;
                BS.enabled = true;

                if (GameObject.FindWithTag("Enemy") == null)
                {
                    sword.SetActive(false);
                    bombe_slot1.SetActive(true);
                    bombe_slot2.SetActive(false);
                    sword_slot1.SetActive(false);
                    sword_slot2.SetActive(true);
                }
                else
                {
                    enemy.GetComponent<SphereCollider>().enabled = false;
                    sword.SetActive(false);
                    bombe_slot1.SetActive(true);
                    bombe_slot2.SetActive(false);
                    sword_slot1.SetActive(false);
                    sword_slot2.SetActive(true);
                }
            }
        }
        if (BS.enabled == true && PB.enabled == true && chest == null)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                FindObjectOfType<AudioManager>().Play("Switch");
                Debug.Log("switch_epee");;
                PS.enabled = true;
                PB.enabled = false;
                BS.enabled = false;
                if (GameObject.FindWithTag("Enemy") == null)
                {
                    sword.SetActive(true);
                    bombe_slot1.SetActive(false);
                    bombe_slot2.SetActive(true);
                    sword_slot1.SetActive(true);
                    sword_slot2.SetActive(false);
                }
                else
                {
                    enemy.GetComponent<SphereCollider>().enabled = true;
                    sword.SetActive(true);
                    bombe_slot1.SetActive(false);
                    bombe_slot2.SetActive(true);
                    sword_slot1.SetActive(true);
                    sword_slot2.SetActive(false);
                }
            }
        }
    }

}