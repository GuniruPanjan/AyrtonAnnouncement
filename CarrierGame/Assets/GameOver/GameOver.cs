using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void OnClickGameScene()  //ゲームシーンへ遷移する
    {
        SceneManager.LoadScene("GameScene1");
    }
}
