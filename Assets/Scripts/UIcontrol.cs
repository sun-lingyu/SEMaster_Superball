using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIcontrol : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPause()//点击“暂停”时执行此方法
    {
        Time.timeScale = 0;
        UI.transform.Find("PausePage").gameObject.SetActive(true);
    }

    public void OnReturn()//点击“恢复”时执行此方法
    {
        Time.timeScale = 1;
        UI.transform.Find("PausePage").gameObject.SetActive(false);
    }

    public void OnReload()//重置游戏场景
    {
        Application.LoadLevel(Application.loadedLevelName);
    }

    public void OnQuit()//退出游戏
    {
        Quit();
    }

    public void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
            Application.Quit();
    #endif
    }

}
