using UnityEngine;

public class songController : MonoBehaviour
{
    public Rigidbody2D songBody;
    public float jumpPower;
    public logicManager logic;
    public bool songleAlive = true;

    AudioSource aud;
    public AudioClip audJump; // ���� �Ҹ�
    public AudioClip audCollision; // �浹 �Ҹ�


    void Start() {
        // logicManager ������Ʈ ��������
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && songleAlive)
        {
            // ����
            songBody.linearVelocity = Vector2.up * jumpPower;

            // ���� ȿ���� �߻�
            this.aud.PlayOneShot(this.audJump);
            this.aud.volume = 0.5f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �浹 ȿ���� ���
        aud.PlayOneShot(audCollision);

        // ���� ���� ó��
        logic.gameOver();
        songleAlive = false;
    }
}