using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerShoot : MonoBehaviour
{
    [FormerlySerializedAs("particles")] [SerializeField] private GameObject[] _particles;
    private List<ParticleSystem.EmissionModule> _particleList = new List<ParticleSystem.EmissionModule>();
    private ParticleSystem.EmissionModule _tempParticle;

    void Start()
    {
        for (int i = 0; i < _particles.Length; i++)
        {
            _tempParticle = _particles[i].GetComponent<ParticleSystem>().emission;
            _particleList.Add(_tempParticle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        ProcessFiring();
    }

    private void ProcessFiring()
    {
        if (Input.GetButton("Fire1"))
        {
            for (int i = 0; i < _particleList.Count;i++)
            {
                var particles = _particleList.ElementAt(i);
                particles.enabled = true;
            }
        }
        else
        {
            for (int i = 0; i < _particleList.Count;i++)
            {
                var particles = _particleList.ElementAt(i);
                particles.enabled = false;
            }
        }
    }
}
