using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public void OnClickTitle()  //ゲームシーンへ遷移する
    {
        SceneManager.LoadScene("Home");
    }
}
