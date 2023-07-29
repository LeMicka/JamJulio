using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionAction : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("enemy"))
        {
            GameManager.instance.kills += 1;
            Destroy(other.gameObject);
            GameManager.instance.enemies.Remove(other.gameObject.transform);
            Destroy(this.gameObject);
        }
    }
}
