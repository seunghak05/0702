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
        // ✅ 수정: linearVelocity → velocity
        bulletRigidbody.linearVelocity = transform.forward * speed;

        Destroy(gameObject, 3f); // 3초 후 자동 제거
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
        // 벽에 닿으면 총알 제거
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
