using UnityEngine;

public class BLBRD : MonoBehaviour
{
    private Transform mainCameraTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = mainCameraTransform.rotation;
    }
}
