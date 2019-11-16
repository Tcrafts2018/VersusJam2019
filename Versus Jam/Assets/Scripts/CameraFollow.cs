using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
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
        if (Input.GetKey("d"))
        {
            transform.Translate(Time.deltaTime * Vector3.right * moveSpeed);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Time.deltaTime * Vector3.left * moveSpeed);
        }
    }
}
