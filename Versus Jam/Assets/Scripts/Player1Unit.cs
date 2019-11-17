using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;
<<<<<<< HEAD
    private bool isAttacking;
    private bool canAttack = true;
    public float P1Uhealth = 40;
    public float P1Udamage;
    public float P2Uh;
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
            P1Udamage = Random.Range(5, 11);
            P2Uh = P2Uh - P1Udamage;
            Debug.Log(P2Uh);
            Debug.Log("P1UAttacked");
            StartCoroutine("AttackReset");
        }

=======
>>>>>>> d72c459a0e21acb9d637cdf1ab83e539427068fb
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player2Unit")
        {
            P2Uh = other.GetComponent<Player2Unit>().P2Uhealth;
            enemyDetected = true;
<<<<<<< HEAD
            isAttacking = true;
=======
            Debug.Log("Enemy Detected");
>>>>>>> d72c459a0e21acb9d637cdf1ab83e539427068fb
        }

        if (other.gameObject.tag == "Player1Unit")
        {
            frambDetected = true;
            Debug.Log("Framb Detected");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player2Unit")
        {
            P1Uhealth = other.GetComponent<Player2Unit>().P1Uh;
            if (P2Uh <= 0)
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
        if (other.gameObject.tag == "Player2Unit")
        {
            enemyDetected = false;
            Debug.Log("Enemy Lost");
        }

        if (other.gameObject.tag == "Player1Unit")
        {
            frambDetected = false;
            Debug.Log("Framb lost");
        }
    }


}
