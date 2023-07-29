using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwaningCivilians : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject civilian;
    //private Vector3 offset = new Vector3(0, 0, -6);

    //public float launchSpeed = 700f;
    private float nextLaunchTime = 0.0f;
    public float period = 0.2f;
    public float timePassed = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(Time.time > nextLaunchTime)
        {
            GameObject newcivilians = Instantiate(civilian, transform.position + new Vector3(Random.Range(-10, 10), 0, -6), transform.rotation);
            GameManager.instance.enemies.Add(newcivilians.transform);
            nextLaunchTime += period;
        }
    }
}
