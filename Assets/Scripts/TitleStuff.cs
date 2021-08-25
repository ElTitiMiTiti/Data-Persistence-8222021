using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleStuff : MonoBehaviour
{
    public static TitleStuff scene1;
    public TMP_InputField inputField;

    public string playerName;

    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
                
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void SetPlayerName()
    {
        playerName = inputField.text;

        SceneManager.LoadSceneAsync("main");

    }
}
