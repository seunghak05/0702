using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime,0f, Space.Self); // Rotate around the Y-axis
    }
}
