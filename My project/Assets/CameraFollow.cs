using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Jugador;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Jugador.transform.position + offset;
    }
}
