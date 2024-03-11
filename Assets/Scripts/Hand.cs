using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Transform HandZone;
    public GameObject[] Cartas;
    private void OrganizarCartas()
    {
        int CantidadCartas = Cartas.Length;
        float Ancho = 1.0f;
        float Separacion = 1.0f;
        for (int i = 0; i < CantidadCartas; i++)
        {
            Vector3 PosicionCarta  = HandZone.position + new Vector3((i - (CantidadCartas - 1) / 2.0f) * (Ancho + Separacion),0,0);
            Cartas[i].transform.position = PosicionCarta;
          
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        OrganizarCartas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
