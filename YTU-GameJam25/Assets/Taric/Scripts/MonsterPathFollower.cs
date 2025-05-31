using System.Collections;
using UnityEngine;

public class MonsterPathFollower : MonoBehaviour
{
    public Vector3[] waypointsPositions; 
    public float speed = 3f;
    private int currentWaypointIndex = 0;
    private bool isMoving = false;

    void Start()
    {
        StartCoroutine(StartMovingAfterDelay(5f));
    }

    void Update()
    {
        if (isMoving && currentWaypointIndex < waypointsPositions.Length)
        {
            MoveAlongPath();
        }
    }

    private void MoveAlongPath()
    {
        Vector3 targetPosition = waypointsPositions[currentWaypointIndex];
        Vector3 direction = (targetPosition - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypointsPositions.Length)
            {
                isMoving = false;
                Debug.Log("Yaratýk hedefe ulaþtý!");
            }
        }
    }

    IEnumerator StartMovingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        isMoving = true;
    }
}
