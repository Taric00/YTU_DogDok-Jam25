using UnityEngine;

public class SceneChecker : MonoBehaviour
{
    void Start()
    {
        bool isChasing = PlayerPrefs.GetInt("isChasing", 1) == 1;
        Debug.Log("isChasing: " + isChasing);

    }
}

