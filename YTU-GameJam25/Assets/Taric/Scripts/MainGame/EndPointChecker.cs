using UnityEngine;

public class EndPointChecker : MonoBehaviour
{
    private GameObject uyarıPanel;

    private void Start()
    {
        uyarıPanel = GameObject.Find("1-Uyari"); 
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
