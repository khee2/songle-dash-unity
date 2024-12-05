using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class logicManager : MonoBehaviour 
{
    public GameObject gameOverScene;

    void Start()
    {
    }

    void Update()
    {
    }

    // 게임을 재시작하는 메서드
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver() {
        gameOverScene.SetActive(true);
    }
}
