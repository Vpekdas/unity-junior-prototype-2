using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Animals;
    private readonly float _spawnRangeX = 15;
    private readonly float _spawnRangeZ = 15;
    private readonly float _startDelay = 2;
    private readonly float _spawnInterval = 1.5f;

    public enum SpawnPos
    {
        Left,
        Top,
        Right
    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, Animals.Length);
        GameObject Animal = Animals[animalIndex];

        SpawnPos pos = (SpawnPos)Random.Range(0, 3);
        Vector3 spawnPos = GenerateRandomPos(pos);
        Quaternion spawnRot = GenerateRandomRot(pos);

        Instantiate(Animal, spawnPos, spawnRot);
    }

    Vector3 GenerateRandomPos(SpawnPos pos)
    {
        return pos switch
        {
            SpawnPos.Left => new Vector3(-20, 0, Random.Range(0, _spawnRangeZ)),
            SpawnPos.Top => new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnRangeZ),
            SpawnPos.Right => new Vector3(20, 0, Random.Range(0, _spawnRangeZ)),
            _ => new Vector3(0, 0, 0),
        };
    }

    Quaternion GenerateRandomRot(SpawnPos pos)
    {
        return pos switch
        {
            SpawnPos.Left => Quaternion.Euler(0, 90, 0),
            SpawnPos.Top => Quaternion.Euler(0, 180, 0),
            SpawnPos.Right => Quaternion.Euler(0, 270, 0),
            _ => Quaternion.Euler(0, 0, 0),
        };
    }

    void Start()
    {
        InvokeRepeating(nameof(SpawnAnimal), _startDelay, _spawnInterval);
    }
}