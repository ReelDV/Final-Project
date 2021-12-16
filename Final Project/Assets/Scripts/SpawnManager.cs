using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnPoints;
    [SerializeField]
    GameObject objectPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObj = Instantiate(objectPrefab, spawn.transform, false);
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
