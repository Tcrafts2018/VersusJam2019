using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyDetected == false && frambDetected == false)
        {
            transform.Translate(Time.deltaTime * Vector3.right * unitMoveSpeed);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player1Unit")
        {
            enemyDetected = true;
            Debug.Log("Enemy Detected");
        }

        if (other.gameObject.tag == "Player2Unit")
        {
            frambDetected = true;
            Debug.Log("Framb Detected");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player1Unit")
        {
            enemyDetected = false;
            Debug.Log("Enemy Lost");
        }

        if (other.gameObject.tag == "Player2Unit")
        {
            frambDetected = false;
            Debug.Log("Framb Lost");
        }
    }
}
