using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistence : MonoBehaviour
{
    public static DataPersistence Instance;
    public string playerName;
    public string bestPlayer;
    public int bestScore;

    private void Awake()
    {
        if(Instance != null) { Destroy(gameObject);return;}
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


}
