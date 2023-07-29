using UnityEngine;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
    public Transform player;
    public List<Transform> enemies = new List<Transform>();
    public float maxDistanceToCheck = 10;

    public Transform GetCloserEnemy()
    {
        if (player == null || enemies.Count == 0)
            return;

        Transform closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (Transform enemy in enemies)
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