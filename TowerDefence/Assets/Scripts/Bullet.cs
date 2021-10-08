using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * 0.1f;
    }

    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
