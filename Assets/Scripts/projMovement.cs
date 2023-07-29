using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projMovement : MonoBehaviour
{
    public float speed = 100;
    public Transform tarjet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, tarjet.position) > 0.2f)
        {
        transform.LookAt(tarjet);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
            
    }
}
