using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float[] rotation = { 0, 90, 180, 270 
    };

    public float correctRotation;
    [SerializeField]
    public bool isPlaced = false;
    public bool IsPlaced => isPlaced; 


    private void Start()
    {
        int rand = Random.Range(0, rotation.Length);
        transform.eulerAngles = new Vector3(0, 0, rotation[rand]);

        if (Mathf.Approximately(transform.eulerAngles.z, correctRotation))
        {
            isPlaced = true;
        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (Mathf.Approximately(transform.eulerAngles.z, correctRotation) && !isPlaced)
        {
            isPlaced = true;
        }
        else if (isPlaced)
        {
            isPlaced = false;
        }
    }
}
