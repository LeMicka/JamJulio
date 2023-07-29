using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projMovement : MonoBehaviour
{
    public Transform player;
    //public List<Transform> enemies = new List<Transform>();
    public float maxDistanceToCheck = 10;

    public float speed = 100;
    //public Transform tarjet;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        Transform tarjet = GetCloserEnemy();
        
        if(Vector3.Distance(transform.position, tarjet.position) > 0.2f)
        {
            transform.LookAt(tarjet);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
            
    }
    public Transform GetCloserEnemy()
    {
        if (player == null || GameManager.instance.enemies.Count == 0)
            return null;

        Transform closestEnemy = GameManager.instance.enemies[0];
        float closestDistance = Mathf.Infinity;

        foreach (Transform enemy in GameManager.instance.enemies)
        {
            Vector3 playerToEnemy = enemy.position - player.position;
            float angle = Vector3.Angle(playerToEnemy, player.forward);

            // Si el ángulo es menor a 90 grados, el enemigo está delante del jugador
            if (angle < 90f)
            {
                float distance = playerToEnemy.magnitude;
                if (distance < closestDistance && distance < maxDistanceToCheck)
                {
                    closestEnemy = enemy;
                    closestDistance = distance;
                }
            }
        }

        return closestEnemy;
    }
}
