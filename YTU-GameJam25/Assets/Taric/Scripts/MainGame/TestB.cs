using UnityEngine;

public class TestB : MonoBehaviour
{
    private GameObject uyarıPanel;

    private void Start()
    {
        uyarıPanel = GameObject.Find("2-Uyari");
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
