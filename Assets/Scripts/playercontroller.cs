
using UnityEngine;


public class playercontroller : MonoBehaviour
{

    public Rigidbody playerRigidbody;
    public float speed = 8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log("xInput: " + xInput);
        float zInput = Input.GetAxis("Vertical");
        //Debug.Log("yInput: " + zInput);

        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0f, zspeed);
        playerRigidbody.linearVelocity = newVelocity;
    }

    public void die()
    {
        gameObject.SetActive(false);
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        gameManager.EndGame();
    }
}
