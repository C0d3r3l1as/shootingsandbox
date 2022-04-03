using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    public GameObject enemyTarget;
    public float moveSpeed;

    Vector3 moveDirection;

    void Update()
    {
        FindPlayerPos();
    }

    //Find target position
    void FindPlayerPos()
    {
        moveDirection = (enemyTarget.transform.position - transform.position).normalized;
        MoveTowardsPlayer(moveDirection);
    }

    //Move towards the targeted position (does not use rigidboddy, just a transform)
    void MoveTowardsPlayer(Vector3 direction)
    {
        transform.position = Vector3.MoveTowards(transform.position, enemyTarget.transform.position, Time.deltaTime * moveSpeed);
    }
}