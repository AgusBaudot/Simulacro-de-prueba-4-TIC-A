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
            int guita = suma - montoTotal;
            Debug.Log("Faltan $" + guita);
        } else if (montoTotal>suma)
        {
            Debug.Log("Los productos no superan el monto disponible");
            int guita = montoTotal - suma;
            Debug.Log("Sobran $" + guita);
        } else if (montoTotal==suma)
        {
            Debug.Log("Los productos no superan el monto disponible");
            Debug.Log("No sobra plata");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
