using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody enemyRigidbody;
    private GameObject player;
    [SerializeField] private float speed = 2;

    private float minHeight = -5f;
    
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    
    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(direction * speed);

        if (transform.position.y < minHeight)
        {
            Destroy(gameObject);
        }
    }
}
