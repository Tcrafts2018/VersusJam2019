using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7.23)
        {
            transform.Translate(Time.deltaTime * Vector3.right * moveSpeed);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -47.58)
        {
            transform.Translate(Time.deltaTime * Vector3.left * moveSpeed);
        }
    }
}