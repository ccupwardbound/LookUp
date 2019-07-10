using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float timer = 0;
    public GameObject PIPE;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPIPE = Instantiate(PIPE);
        newPIPE.transform.position = transform.position + new Vector3(0, Random.Range(-1, 3), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPIPE = Instantiate(PIPE);
            newPIPE.transform.position = transform.position + new Vector3(0, Random.Range(-1, 3), 0);
            Destroy(newPIPE, 10);
            timer = 0;
        }
        timer += Time.deltaTime; 
    }
}
