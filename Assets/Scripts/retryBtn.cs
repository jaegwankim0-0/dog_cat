using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ReGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
