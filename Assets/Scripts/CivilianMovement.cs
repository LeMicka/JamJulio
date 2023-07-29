using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilianMovement : MonoBehaviour
{
    public float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyThis", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void DestroyThis()
    {
        GameManager.instance.enemies.Remove(this.transform);
        Destroy(this.gameObject);
    }
}
