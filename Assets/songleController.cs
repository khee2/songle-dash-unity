using UnityEngine;

public class songController : MonoBehaviour
{
    public Rigidbody2D songBody;
    public float jumpPower;
    public logicManager logic;
    public bool songleAlive = true;

    AudioSource aud;
    public AudioClip audJump; // 점프 소리
    public AudioClip audCollision; // 충돌 소리


    void Start() {
        // logicManager 컴포넌트 가져오기
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicManager>();
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && songleAlive)
        {
            // 점프
            songBody.linearVelocity = Vector2.up * jumpPower;

            // 점프 효과음 발생
            this.aud.PlayOneShot(this.audJump);
            this.aud.volume = 0.5f;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 충돌 효과음 재생
        aud.PlayOneShot(audCollision);

        // 게임 종료 처리
        logic.gameOver();
        songleAlive = false;
    }
}