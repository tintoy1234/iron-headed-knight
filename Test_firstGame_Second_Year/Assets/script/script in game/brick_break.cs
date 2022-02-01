using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick_break : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        if(hit.transform.tag == "Bombe")
        {
            Destroy(gameObject, 0.8f);
        }
    }
}
