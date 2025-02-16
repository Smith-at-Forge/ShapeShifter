using System;
using System.Numerics;
using Unity.Mathematics.Geometry;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    [SerializeField] private float enemyAttackCooldown;
    [SerializeField] private int enemyAttackDamage;
    //
    [SerializeField] BoxCollider2D boxCollider;
    [SerializeField] BoxCollider2D playerLayer;
    
    //private float cooldownTimer = Mathf.Infinity;


    /*
    private void Update()
    {
        cooldownTimer += Time.deltaTime;



        if (cooldownTimer >= enemyAttackCooldown)
        {
            // Attack
        }
    }

    // Check if Player is in Enemy Sight to Trigger following and attack
    private bool PlayerInEnemySight() 
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, , 0, playerLayer);

        return hit.collider != null;
    }

    // Visual of trigger Boßx
    private void OnDrawGizmos() 
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(boxCollider.bounds.center, boxCollider.bounds.size);
    }
    */
}

