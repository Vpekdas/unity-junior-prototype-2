using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float _topBound = 30;
    private readonly float _rightBound = 20;

    private readonly float _lowerBound = -10;

    void Update()
    {
        if (transform.position.z > _topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < _lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        else if (transform.position.x > _rightBound || transform.position.x < -_rightBound)
        {
            Destroy(gameObject);
        }
    }
}