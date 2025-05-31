using UnityEngine;

public class PipeChecker : MonoBehaviour
{
    public PipeScript[] pipes;
    private bool allPlacedAnnounced = false;

    void Update()
    {
        if (allPlacedAnnounced) return; 

        bool allPlaced = true;

        foreach (PipeScript pipe in pipes)
        {
            if (!pipe.IsPlaced)
            {
                allPlaced = false;
                break;
            }
        }

        if (allPlaced)
        {
            GameObject objectA = GameObject.FindWithTag("ObjectA");
            if (objectA != null)
            {
                Destroy(objectA);
            }
        }
    }
}
