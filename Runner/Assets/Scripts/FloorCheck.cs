using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
    public int amountOfSpawn = 5;
    public GameObject spawnTile;
    GameObject checkTile;
    GameObject tilesParent;
    int tileCounter;
    void Start()
    {
        tileCounter = amountOfSpawn-1;
        tilesParent = GameObject.Find("Floors");
        for (var i = 0; i < amountOfSpawn; i++)
        {
            Transform tile = spawnTile.transform.GetChild(0);
            Instantiate(spawnTile, new Vector3(spawnTile.transform.position.x, spawnTile.transform.position.y, i * tile.localScale.z), Quaternion.identity, tilesParent.transform);
        }
    }

    void OnTriggerExit(Collider other)
    {
        tileCounter += 1;
        if (other.tag == "ground") {
            Transform tile = spawnTile.transform.GetChild(0);
            Instantiate(spawnTile, new Vector3(spawnTile.transform.position.x, spawnTile.transform.position.y, tileCounter * tile.localScale.z), Quaternion.identity, tilesParent.transform);
            Destroy(other.transform.parent.gameObject);
        }
    }

    void Update()
    {
        
    }
}
