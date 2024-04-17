using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene("Level 2");
    }

    public void LoadLevel3()
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene("Level 3");
    }

    public void backtomain()
    {
        Debug.Log("back Button Pressed");
        SceneManager.LoadScene("Menu");
    }
}
