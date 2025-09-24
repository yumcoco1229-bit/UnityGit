using UnityEngine;

public class CubeConroller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, transform.position.x * 1.0f, 0);
    }
}
