﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;
<<<<<<< HEAD

=======
>>>>>>> parent of 1ef9eed... Delete
    private bool isAttacking;
    private bool canAttack = true;
    public float P1Uhealth = 40;
    public float P1Udamage;
    public float P2Uh;
<<<<<<< HEAD

=======
>>>>>>> parent of 1ef9eed... Delete
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

=======
>>>>>>> parent of 1ef9eed... Delete

        if (isAttacking == true && canAttack == true)
        {
            canAttack = false;
            P1Udamage = Random.Range(15, 26);
            P2Uh = P2Uh - P1Udamage;
            Debug.Log("P1UAttacked");
            StartCoroutine("AttackReset");
        }
        if (P1Uhealth <= 0)
        {
            Destroy(gameObject);
            enemyDetected = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        P2Uh = other.GetComponent<Player2Unit>().P2Uhealth;
        if (other.gameObject.tag == "Player2Unit")
        {
            enemyDetected = true;
            isAttacking = true;
<<<<<<< HEAD
<<<<<<< HEAD
            Debug.Log("Enemy Detected");
=======
>>>>>>> parent of 1ef9eed... Delete
=======
            Debug.Log("Enemy Detected");
>>>>>>> parent of 4dd5357... HealthWorks
        }

        if (other.gameObject.tag == "Player1Unit")
        {
            frambDetected = true;
            Debug.Log("Framb Detected");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player2Unit")
        {
            enemyDetected = false;
            isAttacking = false;
            Debug.Log("Enemy Lost");
        }

        if (other.gameObject.tag == "Player1Unit")
        {
            frambDetected = false;
            Debug.Log("Framb lost");
        }
    }

    IEnumerator AttackReset()
    {
        yield return new WaitForSeconds(1);
        canAttack = true;
    }
}
