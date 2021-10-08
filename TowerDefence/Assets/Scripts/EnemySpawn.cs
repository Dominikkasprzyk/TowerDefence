using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    [SerializeField]
    private float interval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        enemies = new List<GameObject>();
        InvokeRepeating("SpawnNewEnemy", 0.0f, interval);
       
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var enemy in enemies)
        {
            enemy.transform.position += new Vector3(0,1,0);
        }
    }

    private void SpawnNewEnemy()
    {
        var enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        enemy.transform.parent = this.transform;
        enemies.Add(enemy);
    }
}
