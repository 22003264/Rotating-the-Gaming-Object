using UnityEngine;

public class rotaye : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.up,Vector3.left,40*Time.deltaTime);
    }
}
