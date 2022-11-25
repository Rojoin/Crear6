using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWorld : MonoBehaviour
{
    [SerializeField] private Transform leverPart1;

    private void Awake()
    {
        SpawnLevelPart(new Vector3(134, 9));
        SpawnLevelPart(new Vector3(134, 9) + new Vector3(70, 0));
        SpawnLevelPart(new Vector3(134, 9) + new Vector3(70 + 70, 0));
    }

    private void SpawnLevelPart(Vector3 spawnPosition)
    {
        Instantiate(leverPart1, spawnPosition, Quaternion.identity);

    }
    void Update()
    {
        
    }
}
