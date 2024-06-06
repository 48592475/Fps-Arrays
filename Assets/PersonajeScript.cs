using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeScript : MonoBehaviour
{
    public int NivelHambre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TomarAlimento(int ValorAlimentario)
    {
        NivelHambre -= ValorAlimentario;
        if (NivelHambre <= 0)
        {
            NivelHambre = 0;

        }
    }
    //poner al interactionarea is tigger para poder atravezar
    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            TomarAlimento(alimento.ValorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
