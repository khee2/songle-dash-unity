using UnityEngine;

public class bookController : MonoBehaviour
{
    public float moveSpeed = 5; // �̵� �ӵ�
    public float deadLine = -45; // ������Ʈ ���� ���� ��ġ

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �������� �̵�
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // ������ deadLine���� �������� �̵��ϸ� ������Ʈ ����
        if (transform.position.x < deadLine)
        {
            Destroy(gameObject); 
        }
    }
}
