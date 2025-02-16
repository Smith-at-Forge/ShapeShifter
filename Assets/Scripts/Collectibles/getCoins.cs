using System;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class getCoins : MonoBehaviour, ICollectible
{
    public static getCoins instance;
    [SerializeField] private AudioClip sound_coin_collected;

    public static event Action OnCoinCollected;
    Rigidbody2D rb;
    bool hasTarget;
    Vector3 targetPosition;
    float moveSpeed = 8f;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Collect()
    {
        //SoundManager.instance.PlaySound(sound_coin_collected);
        Destroy(gameObject);
        OnCoinCollected?.Invoke();
    }

    private void FixedUpdate()
    {
        if(hasTarget)
        {
            Vector2 targetDirection = (targetPosition - transform.position).normalized;
            rb.linearVelocity = new Vector2(targetDirection.x, targetDirection.y)* moveSpeed;
        }
    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }
}
