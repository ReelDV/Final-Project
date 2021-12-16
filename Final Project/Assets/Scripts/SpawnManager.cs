using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Spawner;
    [SerializeField]
    GameObject LightRemote;
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
        foreach (GameObject spawn in Spawner)
        {
            GameObject spawnObj = Instantiate(LightRemote, spawn.transform, false);
            objectScript objScript = spawnObj.GetComponent<objectScript>();
            objScript.floatSpeed = Random.Range(1, 3);
            //spawnObj.GetComponent<objectScript>().floatSpeed = Random.Range(1, 3);
            int randomNum = Random.Range(1, 4);
            if (randomNum <=2)
            {
                objScript.isCorrect = true;
            }else
            {
                objScript.isCorrect = false;
            }    
        }
    }

}
