using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTowers : MonoBehaviour
{
    [SerializeField] int n;

    //random position boundries
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minZ;
    [SerializeField] float maxZ;
    [SerializeField] float y;

    [SerializeField] GameObject towerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        RandomlySpawnTowers();
    }

    private void RandomlySpawnTowers()
    {
        for (int i = 0; i < n; i++)
        {
            GameObject tower = GameObject.Instantiate((towerPrefab), new Vector3(Random.Range(minX, maxX),  y, Random.Range(minZ, maxZ)), Quaternion.identity);
        }
    }
}
