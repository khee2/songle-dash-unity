using UnityEngine;
using Random = UnityEngine.Random;

public class spawnerController : MonoBehaviour
{
    public GameObject book;
    public float spawnRate = 2;
    public float timer = 0;
    public float defaultHeight = 15; // ��� ���� y��ǥ�� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnBook();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnBook();
            timer = 0;
        }
    }

    // SpawnBook �޼��尡 Ŭ������ ����� ���ǵ�
    void SpawnBook()
    {
        float lowestHeight = transform.position.y - defaultHeight;
        float highestHeight = transform.position.y + defaultHeight;

        Instantiate(book, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}
