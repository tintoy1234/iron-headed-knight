using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe_script : MonoBehaviour
{
    public GameObject BOOM;
    Renderer rend;
    private void Start()
    {
        BOOM.SetActive(false);
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -2, transform.position.z);
            transform.parent = null;
            StartCoroutine(boomanim());
        }
    }
    IEnumerator boomanim()
    {
        yield return new WaitForSeconds(0.8f);
        BOOM.SetActive(true);
        rend.enabled = false;
        FindObjectOfType<AudioManager>().Play("Boom");
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
