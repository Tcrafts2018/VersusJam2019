using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Unit : MonoBehaviour
{
    public float unitMoveSpeed;
    public bool enemyDetected = false;
    private bool frambDetected = false;
    private bool isAttacking;
    private bool canAttack = true;
    static public float P1Uhealth = 40;
    static public float P1Udamage;
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
            P1Udamage = Random.Range(15, 26);
            Player2Unit.P2Uhealth = Player2Unit.P2Uhealth - P1Udamage;
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
        if (other.gameObject.tag == "Player2Unit")
        {
            enemyDetected = true;
            isAttacking = true;
            Debug.Log("Enemy Detected");
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
