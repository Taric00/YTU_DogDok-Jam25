using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameButton : MonoBehaviour
{
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
