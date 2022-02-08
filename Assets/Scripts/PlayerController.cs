using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidbody;
    [SerializeField] private float speed = 10f;
    private GameObject focalPoint;
    private bool hasPowerUp;
    private float powerUpForce = 15f;
    
    public GameObject[] powerupIndicators;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");  //enfoque al player
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
            StartCoroutine(PowerUpCountDown());
        }

    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (hasPowerUp && otherCollider.gameObject.CompareTag("enemy"))
        {
            Rigidbody enemyRigidbody = otherCollider.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (otherCollider.gameObject.transform.position - transform.position);

            enemyRigidbody.AddForce(awayFromPlayer * powerUpForce, ForceMode.Impulse);
        }
    }


    private IEnumerator PowerUpCountDown()
    {
        for (int i = 0; i < powerupIndicators.Length; i++)
        {
            powerupIndicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerupIndicators[i].SetActive(false);
        }
        yield return new WaitForSeconds(6);
        hasPowerUp = false;
    }
}
