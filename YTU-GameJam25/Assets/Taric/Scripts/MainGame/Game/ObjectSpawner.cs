using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [Header("Bölgeler için prefablar")]
    public GameObject prefabA;
    public GameObject prefabB;
    public GameObject prefabC;

    [Header("Bölgelerin pozisyonlarý")]
    public Transform regionAPosition;
    public Transform regionBPosition;
    public Transform regionCPosition;

    [Header("Spawn Süresi iþte")]
    public float spawnInterval = 10f;

    public GameObject canvasObjectA,canvasObjectB, canvasObjectC;

    private int lastPrefabIndex = -1; //son spawn edilen obje nosu

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnRandomObject();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    public void SpawnRandomObject()
    {
        int newPrefabIndex;

        do
        {
            newPrefabIndex = Random.Range(0, 3);
        } while (newPrefabIndex == lastPrefabIndex);

        lastPrefabIndex = newPrefabIndex;

        switch (newPrefabIndex)
        {
            case 0:
                Instantiate(prefabA, regionAPosition.position, Quaternion.identity);
                Debug.Log("A bölgesine spawn edildi");
                EnableCanvasA();
                break;
            case 1:
                Instantiate(prefabB, regionBPosition.position, Quaternion.identity);
                Debug.Log("B bölgesine spawn edildi");
                EnableCanvasB();
                break;
            case 2:
                Instantiate(prefabC, regionCPosition.position, Quaternion.identity);
                Debug.Log("C bölgesine spawn edildi");
                EnableCanvasC();
                break;
        }
    }

    public void EnableCanvasA()
    {
        if (canvasObjectA != null)
            canvasObjectA.SetActive(true);
    }

    public void EnableCanvasB()
    {
        if (canvasObjectB != null)
            canvasObjectB.SetActive(true);
    }

    public void EnableCanvasC()
    {
        if (canvasObjectC != null)
            canvasObjectC.SetActive(true);
    }
}
