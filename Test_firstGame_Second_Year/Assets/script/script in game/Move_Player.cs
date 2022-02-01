using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Player : MonoBehaviour
{
    public float speed = 0.5f;
    public float turn = 0.1f;
    float turnvelocity;
    public Transform camera;
    CharacterController player;
    private void Start()
    {
        Cursor.visible = false;
        player = GetComponent<CharacterController>();
    }
    void Update()
    {
        float translation = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        float rotation = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        Vector3 direction = new Vector3(rotation, 0, translation).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float angleofview = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angleofview, ref turnvelocity, turn);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveindirection = Quaternion.Euler(0f, angleofview, 0f) * Vector3.forward;
            player.Move(moveindirection.normalized * speed * Time.deltaTime);
            //transform.position += new Vector3(Mathf.Cos(angleofview) * speed * Time.deltaTime, 0f, Mathf.Sin(angleofview)) * speed * Time.deltaTime;
        }
    }
}
