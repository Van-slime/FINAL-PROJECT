using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour
{
    public GameObject gameOverPanel;
    
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameOverPanel.SetActive(true);
        }
    }
    public void tombol()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
