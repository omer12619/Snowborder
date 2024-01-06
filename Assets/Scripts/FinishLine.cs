using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]ParticleSystem m_ParticleSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            Debug.Log("OHH WE WIN");
            m_ParticleSystem.Play();
            Invoke("load_zero", 0.5f);



    }
    private void load_zero()
    {
        SceneManager.LoadScene(0);
    }
}

