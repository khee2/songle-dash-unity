using UnityEngine;

public class bookController : MonoBehaviour
{
    public float moveSpeed = 5; // 이동 속도
    public float deadLine = -45; // 오브젝트 삭제 기준 위치

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽으로 이동
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // 지정된 deadLine보다 왼쪽으로 이동하면 오브젝트 삭제
        if (transform.position.x < deadLine)
        {
            Destroy(gameObject); 
        }
    }
}
