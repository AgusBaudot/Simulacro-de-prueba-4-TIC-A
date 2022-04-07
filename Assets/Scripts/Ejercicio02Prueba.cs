using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    public int precio1;
    public int precio2;
    public int precio3;
    public int montoTotal;
    void Start()
    {
        int suma = precio1 + precio2 + precio3;
        if (suma>montoTotal)
        {
            Debug.Log("Los productos superan el monto disponible");
        } else if (montoTotal>suma)
        {
            Debug.Log("Los productos no superan el monto disponible");
        } else if (montoTotal==suma)
        {
            Debug.Log("Los productos no superan el monto disponible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
