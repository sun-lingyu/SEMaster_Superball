using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene("5.2_v");
    }
}
