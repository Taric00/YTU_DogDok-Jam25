using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDap : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CodeText;
    [SerializeField] private GameObject warningCanvas; 
    public string safeCode;
    private string codeTextValue = "";

    void Update()
    {
        CodeText.text = codeTextValue;

        if (codeTextValue == safeCode)
        {
            if (warningCanvas != null)
            {
                warningCanvas.SetActive(false);
            }

            GameObject objectA = GameObject.FindWithTag("ObjectA");
            if (objectA != null)
            {
                Destroy(objectA);
            }
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
