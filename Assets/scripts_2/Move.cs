using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public Transform childTransform; // 자식 Transform을 할당할 변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -1, 0); // 초기 위치 설정

        childTransform.localPosition = new Vector3(0, 2, 0);

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30)); // 초기 회전 설정

        childTransform.localRotation = Quaternion.Euler(new Vector3(0, 60, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime); // 위로 이동
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime); // 아래로 이동
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime); // 왼쪽으로 회전
            childTransform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime); // 자식도 왼쪽으로 회전
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime); // 오른쪽으로 회전
            childTransform.Rotate(new Vector3(0, -180, 0) * Time.deltaTime); // 자식도 오른쪽으로 회전
        }
        if(Input.GetMouseButton(0))
        {
            childTransform.Translate(new Vector3(0, 10, 0) * Time.deltaTime * 100);
        }
    }

}
