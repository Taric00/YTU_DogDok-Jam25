using UnityEngine;

public class TestC : MonoBehaviour
{
    private GameObject uyarıPanel;

    private void Start()
    {
        uyarıPanel = GameObject.Find("3-Uyari");
        if (uyarıPanel != null)
            uyarıPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EndPoint"))
        {
            if (uyarıPanel != null)
            {
                uyarıPanel.SetActive(true);
            }
        }
    }
}
