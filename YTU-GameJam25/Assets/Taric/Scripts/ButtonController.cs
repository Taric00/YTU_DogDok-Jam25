using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public void OnButtonPress()
    {
        PlayerPrefs.SetInt("isChasing", 1);
        Debug.Log("isChasing tekrar true oldu!");
    }
}
