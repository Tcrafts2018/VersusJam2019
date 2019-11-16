using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public GameObject SpawnLoc;
    public GameObject Unit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Debug.Log("Miner2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Debug.Log("Attacker2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            Debug.Log("Heavy2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Special2 Spawned");
            Instantiate(Unit, SpawnLoc.transform.position, SpawnLoc.transform.rotation);
        }
    }
}
