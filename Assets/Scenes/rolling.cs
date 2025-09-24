using UnityEngine;

public class rolling : MonoBehaviour
{
    public float rollX;
    public float rollY;
    public float rollZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rollX, rollY, rollZ);
    }
}
