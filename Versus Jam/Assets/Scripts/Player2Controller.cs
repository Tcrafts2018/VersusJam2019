using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public GameObject SpawnLoc;
    public GameObject Unit;
    private bool isSpawning = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Miner2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Attacker2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Heavy2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Special2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }
    }

    IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(2);
        isSpawning = false;
    }
}
