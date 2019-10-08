using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public Transform pointerDes;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateCube()
    {
        GameObject obj = Instantiate(cube, pointerDes.position, Quaternion.identity) as GameObject;
    }
}
