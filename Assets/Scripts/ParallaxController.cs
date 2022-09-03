using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    private float startpos;
    [SerializeField] private Transform cam;
    [SerializeField] private float parallaxEffect;

    void Start()
    {
        cam = Camera.main.transform;
        startpos = transform.position.x;
    }
    void Update()
    {
        float distance = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);
    }
}
