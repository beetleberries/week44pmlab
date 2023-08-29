using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, Vector3.right * 2, Quaternion.identity);
        Instantiate(blueObj, Vector3.right * -2, Quaternion.identity);

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
