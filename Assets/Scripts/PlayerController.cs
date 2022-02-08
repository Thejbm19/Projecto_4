using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    [SerializeField]private float speed = 10f;
    private GameObject focalPoint;
    private bool hasPowerUp;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * speed * verticalInput);
    }

    public void OnTriggerEnter(Collider otherCollider)
    {
        
        if (otherCollider.gameObject.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            Destroy(otherCollider.gameObject);
        }

    }
}
