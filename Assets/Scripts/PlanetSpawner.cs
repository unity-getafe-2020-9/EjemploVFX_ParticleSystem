using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject[] prefabsPlanetas;
    public int numeroDePlanetas;
    public float escalaPlanetas;
    public float radioUniverso;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numeroDePlanetas; i++)
        {
            Vector3 posicion = new Vector3(
                Random.Range(-radioUniverso, radioUniverso),
                Random.Range(-radioUniverso, radioUniverso),
                Random.Range(-radioUniverso, radioUniverso));
            GameObject nuevoPlaneta = Instantiate(prefabsPlanetas[Random.Range(0, prefabsPlanetas.Length)], posicion, transform.rotation);
            nuevoPlaneta.transform.localScale = new Vector3(escalaPlanetas, escalaPlanetas, escalaPlanetas);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
