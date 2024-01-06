using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem m_ParticleSystem;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            FindObjectOfType<PlayerMove>().dismove();
            Debug.Log("Ouch,hit my head");
            GetComponent<AudioSource>().Play();
            m_ParticleSystem.Play();
            Invoke("load_zero",0.5f);
        }
    }
    private void load_zero()
    {
        SceneManager.LoadScene(0);
    }
}
