using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField]ParticleSystem m_ParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
      m_ParticleSystem.Play();
    }
    private void OnCollisionExit(Collision collision)
    {
       m_ParticleSystem.Stop();
    }
}
