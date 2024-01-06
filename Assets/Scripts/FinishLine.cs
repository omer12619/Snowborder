using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            Debug.Log("OHH WE WIN");
            SceneManager.LoadScene(0);
        
        
        
    }
}
