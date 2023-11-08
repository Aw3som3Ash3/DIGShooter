using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 3f;
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}
