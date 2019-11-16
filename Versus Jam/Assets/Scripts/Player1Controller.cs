using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Miner1 Spawned");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Attacker1 Spawned");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Heavy1 Spawned");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Special1 Spawned");
        }
    }
}
