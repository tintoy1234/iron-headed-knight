using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_script : MonoBehaviour
{
    public GameObject E;
    public GameObject chest;
    public GameObject chestCHILD;
    public GameObject chestchild;
    public GameObject chestchilD;
    public GameObject chest2;
    public GameObject chest2CHILD;
    public GameObject chest2child;
    public GameObject chest2chilD;
    public GameObject BOOM1;
    public GameObject BOOM2;
    public Renderer chestbombe;
    public Renderer chestbombe2;
    void Start()
    {
        BOOM1.SetActive(false);
        BOOM2.SetActive(false);
        E.SetActive(false);
    }
    void OnTriggerStay(Collider hit)
    {
        if (hit.transform.tag == "Chest1")
        {
            Vector3 E_touch = Camera.main.WorldToScreenPoint(new Vector3(chest.transform.position.x + 0.5f, chest.transform.position.y + 1.5f, chest.transform.position.z +0.7f));
            E.transform.position = E_touch;
            E.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                BOOM1.SetActive(true);
                chestbombe.enabled = false;
                Destroy(chestCHILD);
                Destroy(chestchild);
                Destroy(chestchilD);
                chest.GetComponent<BoxCollider>().enabled = false;
                chest.GetComponent<SphereCollider>().enabled = false;
                Destroy(hit.gameObject,1);
                E.SetActive(false);
            }
        }
        if (hit.transform.tag == "Chest2")
        {
            Vector3 E_touch = Camera.main.WorldToScreenPoint(new Vector3(chest2.transform.position.x + 0.7f, chest2.transform.position.y + 1.5f, chest2.transform.position.z -0.3f));
            E.transform.position = E_touch;
            E.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                BOOM2.SetActive(true);
                chestbombe2.enabled = false;
                Destroy(chest2CHILD);
                Destroy(chest2child);
                Destroy(chest2chilD);
                chest2.GetComponent<BoxCollider>().enabled = false;
                chest2.GetComponent<SphereCollider>().enabled = false;
                Destroy(hit.gameObject,1);
                E.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        E.SetActive(false);
        Debug.Log("partie");
    }
}