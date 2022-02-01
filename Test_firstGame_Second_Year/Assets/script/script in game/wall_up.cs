using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_up : MonoBehaviour
{
    public float speed = 3f;
    void Update()
    {
        if (GameObject.FindWithTag("Enemy") == null)
        {
            transform.Translate(new Vector3(0, 11, 0) * speed * Time.deltaTime);
        }
        if (transform.position.y >= 12)
        {
            speed = 0;
        }
    }
}
