﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;
<<<<<<< HEAD
    private bool isAttacking;
    private bool canAttack = true;
    public float P2Uhealth = 40;
    public float P2Udamage;
    public float P1Uh;
=======
>>>>>>> d72c459a0e21acb9d637cdf1ab83e539427068fb
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
<<<<<<< HEAD

        if (isAttacking == true && canAttack == true)
        {    
            canAttack = false;
            P2Udamage = Random.Range(5, 11);
            P1Uh = P1Uh - P2Udamage;
            Debug.Log(P1Uh);
            Debug.Log("P2UAttacked");
            StartCoroutine("AttackReset");
        }
=======
>>>>>>> d72c459a0e21acb9d637cdf1ab83e539427068fb
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1Unit")
        {
            P1Uh = other.GetComponent<Player1Unit>().P1Uhealth;
            enemyDetected = true;
<<<<<<< HEAD
            isAttacking = true;
=======
            Debug.Log("Enemy Detected");
>>>>>>> d72c459a0e21acb9d637cdf1ab83e539427068fb
        }

        if (other.gameObject.tag == "Player2Unit")
        {
            frambDetected = true;
            Debug.Log("Framb Detected");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player1Unit")
        {
            P2Uhealth = other.GetComponent<Player1Unit>().P2Uh;
            if (P1Uh <= 0)
            {
                Destroy(other.gameObject);
                enemyDetected = false;
                isAttacking = false;
                canAttack = true;
            }
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
