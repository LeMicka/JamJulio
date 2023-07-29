using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDamage : MonoBehaviour
{
    public Animator anim;

    public void DoAnimation()
    {
        anim.SetTrigger("Activate");
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("enemy"))
        {
            GameManager.instance.enemies.Remove(other.transform);
            Destroy(other.gameObject);
        }
    }
}
