using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunning : MonoBehaviour
{
    public Transform PlatformObj;
    private Vector3 nextTileSpawn;

    void Start()
    {
        nextTileSpawn.z = 5;
        StartCoroutine(spawnTile());
    }

    void Update()
    {
        
    }
    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        Instantiate(PlatformObj, nextTileSpawn, PlatformObj.rotation);
        nextTileSpawn.z += 5;
        StartCoroutine(spawnTile());
    }
}
