using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataPersistence.Instance.playerName = null;
    }

    public void Play()
    {
        if (DataPersistence.Instance.playerName == null)
        {
            DataPersistence.Instance.playerName = $"anonymous";
        }
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SetPlayerName(string entry)
    {
        DataPersistence.Instance.playerName = entry;
    }
}
