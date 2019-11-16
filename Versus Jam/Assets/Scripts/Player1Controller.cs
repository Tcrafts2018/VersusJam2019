using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject SpawnLoc;
    public GameObject Unit;
    private bool isSpawning;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Miner1 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Attacker1 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && isSpawning == false)
        {
            isSpawning = true;
            Debug.Log("Heavy1 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
            StartCoroutine("WaitToSpawn");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && isSpawning == false )
        {
            isSpawning = true;
            Debug.Log("Special1 Spawned");
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
