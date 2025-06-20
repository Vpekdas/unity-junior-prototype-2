using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] BallPrefabs;

    private readonly float _spawnLimitXLeft = -22;
    private readonly float _spawnLimitXRight = 7;
    private readonly float _spawnPosY = 30;

    private float _spawnInterval;
    private float _currentTime;

    void Start()
    {
        _spawnInterval = Random.Range(3.0f, 5.0f);
    }

    void Update()
    {
        if (_currentTime >= _spawnInterval)
        {
			_currentTime = 0.0f;
            _spawnInterval = Random.Range(3.0f, 5.0f);
            SpawnRandomBall();
        }
        _currentTime += Time.deltaTime;
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new(Random.Range(_spawnLimitXLeft, _spawnLimitXRight), _spawnPosY, 0);
        int i = Random.Range(0, BallPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(BallPrefabs[i], spawnPos, BallPrefabs[i].transform.rotation);
    }
}
