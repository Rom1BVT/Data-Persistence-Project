using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIManager : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        DataPersistence.Instance.playerName = null;

        if (DataPersistence.Instance.bestScore != 0)
        {
            bestScoreText.text = $"Best Score\r\n{DataPersistence.Instance.bestPlayer} = {DataPersistence.Instance.bestScore}";
        }
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
        DataPersistence.Instance.SaveScore();
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
