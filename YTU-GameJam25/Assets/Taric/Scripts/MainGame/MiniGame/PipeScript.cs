using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float[] rotation = { 0, 90, 180, 270 };

    public float correctRotation;
    [SerializeField]
    bool isPlaced = false;

    private void Start()
    {
        int rand = Random.Range(0, rotation.Length);
        transform.eulerAngles = new Vector3(0 , 0, rotation[rand]);

        if(transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
        }
    }



    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if(transform.eulerAngles.z == correctRotation && isPlaced == false)
        {
            isPlaced = true;
        }
        else if(isPlaced == true)
        {
            isPlaced = false;
        }
    }
}
