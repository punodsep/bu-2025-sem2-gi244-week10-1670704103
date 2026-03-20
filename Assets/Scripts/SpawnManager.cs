using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public Vector3 spawnPos = new(25, 0, 0);

    public float startDelay = 2;
    public float repeatRate = 2;

    private PlayerControllerExam02 playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate(obstaclePrefab, new Vector3(25, 0, 0), obstaclePrefab.transform.rotation);

        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);

        playerController = GameObject.Find("Player").GetComponent<PlayerControllerExam02>();
    }

    void SpawnObstacle()
    {
        int i = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[i], spawnPos, obstaclePrefab[i].transform.rotation);
    }
}
