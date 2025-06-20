using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private readonly float _leftLimit = -30;
    private readonly float _bottomLimit = -5;

    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < _leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < _bottomLimit)
        {
            Destroy(gameObject);
            Debug.Log("Game Over !");
        }

    }
}
