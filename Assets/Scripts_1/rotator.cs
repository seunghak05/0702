using UnityEngine;

public class rotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation in degrees per second
    // private Rigidbody gameover; // 게임 오버 상태를 나타내는 변수

    // Update is called once per frame
    void Update()
    {
        // while (!gameover)
        // {
            
        // }
        transform.Rotate(0f, rotationSpeed * Time.deltaTime,0f, Space.Self); // Rotate around the Y-axis
    }
}
