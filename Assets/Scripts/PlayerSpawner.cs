using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject spawnObject;

    private void Start()
    {
        
        Instantiate(PlayerStorage.playerPrefab,spawnObject.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
        
    }
}
