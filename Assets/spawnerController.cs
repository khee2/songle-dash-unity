using UnityEngine;
using Random = UnityEngine.Random;

public class spawnerController : MonoBehaviour
{
    public GameObject book;
    public float spawnRate = 2;
    public float timer = 0;
    public float defaultHeight = 15; // 기둥 스폰 y좌표의 기준

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

    // SpawnBook 메서드가 클래스의 멤버로 정의됨
    void SpawnBook()
    {
        float lowestHeight = transform.position.y - defaultHeight;
        float highestHeight = transform.position.y + defaultHeight;

        Instantiate(book, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}
