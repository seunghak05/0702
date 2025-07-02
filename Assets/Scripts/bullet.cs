using UnityEngine;
using UnityEngine.Rendering;

public class bullet : MonoBehaviour
{
    public Rigidbody bulletRigidbody;
    public float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        // Set the bullet's velocity
        bulletRigidbody.linearVelocity = transform.forward * speed;
        
        Destroy(gameObject, 3f); // Destroy the bullet after 2 seconds
    }

    void OnTriggerEnter(Collider other)
    {
                    Debug.Log("Player hit by bullet");

        if (other.tag == "Player")
        {
            Debug.Log("Player hit by bullet1");
            playercontroller playercontroller = other.GetComponent<playercontroller>();
            if (playercontroller != null)
            {
                playercontroller.die();
            }

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
