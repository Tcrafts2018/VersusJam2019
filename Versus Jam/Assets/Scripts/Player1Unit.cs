using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Unit : MonoBehaviour
{
    public float unitmoveSpeed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * Vector3.right * unitmoveSpeed);
    }
}
