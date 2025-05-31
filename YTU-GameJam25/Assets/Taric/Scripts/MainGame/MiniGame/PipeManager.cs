using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipeHolder;
    public GameObject[] pipes;

    [SerializeField] 
    int totalPipes;

    private void Start()
    {
        totalPipes = pipeHolder.transform.childCount;

        pipes = new GameObject[totalPipes];

        for(int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = pipeHolder.transform.GetChild(i).gameObject;
        }
    }
}
