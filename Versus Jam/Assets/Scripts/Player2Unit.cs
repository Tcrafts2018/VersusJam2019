using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;

    private bool isAttacking;
    private bool canAttack = true;
<<<<<<< HEAD
    public float P2Uhealth = 40;
    public float P2Udamage;
    public float P1Uh;

=======
    static public float P2Uhealth = 40;
    static public float P2Udamage;
>>>>>>> parent of 112dd46... NullReferenceException
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


        if (isAttacking == true && canAttack == true)
        {
            canAttack = false;
            P2Udamage = Random.Range(15, 26);
<<<<<<< HEAD
            Player1Unit.P1Uhealth = Player1Unit.P1Uhealth - P2Udamage;
            Debug.Log("P2UAttacked");
            StartCoroutine("AttackReset");
        }

=======
            P1Uh = P1Uh - P2Udamage;
            Debug.Log("P2UAttacked");
            StartCoroutine("AttackReset");
        }
>>>>>>> parent of 4dd5357... HealthWorks
        if (P2Uhealth <= 0)
        {
            Destroy(gameObject);
            enemyDetected = false;
        }
<<<<<<< HEAD

=======
>>>>>>> parent of 4dd5357... HealthWorks
    }

    private void OnTriggerStay(Collider other)
    {
        P1Uh = other.GetComponent<Player1Unit>().P1Uhealth;
        if (other.gameObject.tag == "Player1Unit")
        {
            enemyDetected = true;
            isAttacking = true;
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
