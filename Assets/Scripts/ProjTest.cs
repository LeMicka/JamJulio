using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjTest : MonoBehaviour
{

    public GameObject Projectile;
    //public float launchSpeed = 700f;
    private float nextLaunchTime = 0.0f;
    public float period = 3f;
    public float timePassed = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        if(Time.time > nextLaunchTime)
        {
        //do something
            GameObject proj = Instantiate(Projectile, transform.position, transform.rotation);
            nextLaunchTime += period;
        } 
        //the time isn't flowing here
        //if ( ) {
            //proj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchSpeed,0));
        //    nextLaunchTime += period;
        // execute block of code here
        //}
    }
}
