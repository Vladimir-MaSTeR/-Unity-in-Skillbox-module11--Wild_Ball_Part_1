using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinichControl : MonoBehaviour
{
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private Canvas finishCanfas;
    [SerializeField] private ParticleSystem[] particles;


    // Start is called before the first frame update
    void Start()
    {
        finishPanel.SetActive(false);
        StartAndStopParticle(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        finishCanfas.gameObject.SetActive(false);
        finishPanel.SetActive(true);
        StartAndStopParticle(true);
    }

    private void StartAndStopParticle(bool start)
    {
        if (start && particles.Length != 0)
        {
            foreach (ParticleSystem item in particles)
            {
                item.Play();
            }
        } else
        {
            foreach (ParticleSystem item in particles)
            {
                item.Stop();
            }
        }
        
    }

}
