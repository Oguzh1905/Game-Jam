using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{

    public float waitforAnyKey = 2f;

    public GameObject anyKeyTest;

    public string mainMenuScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(waitforAnyKey > 0)
        {
            waitforAnyKey -= Time.deltaTime;
            if(waitforAnyKey <= 0)
            {
                anyKeyTest.SetActive(true);
            }
        }
        else
        {
            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(mainMenuScene);
            }
        }

        
    }
}
