using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Draw : MonoBehaviour
{
    public GameObject HandZone;
    public GameObject Card;
    public GameObject Card1;
    public float espaciado;
    public int CantidadCartas;
    public float distance = 0;
    List<GameObject> Cartas = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        Cartas.Add(Card);   
        Cartas.Add (Card1);
    }
    public void OnMouseDown()
    {
        float Ancho = (CantidadCartas - 1) * espaciado;
        float InitialPosZ = HandZone.transform.position.z - Ancho / 2;
        for (var i = 0; i < CantidadCartas; i++)
        {
            float PosZ = InitialPosZ + i * espaciado;
            Vector3 CardPosition = new Vector3(HandZone.transform.position.x - 0.2f,HandZone.transform.position.y + 0.5f,PosZ);
           
                GameObject GameCard = Instantiate(Cartas[Random.Range(0, Cartas.Count)], CardPosition, Quaternion.Euler(0, -90, 0));
            
            //GameCard.transform.position = new Vector3(HandZone.transform.position.x,HandZone.transform.position.y + 0.05f,HandZoneZ - 30);
            //HandZoneZ += espaciado;
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }






}
