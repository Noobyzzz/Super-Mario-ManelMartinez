using UnityEngine;

public class P : MonoBehaviour
{
    private int numeroEntero = 5;

    private float numeroDecimal = 7.5f;

    private bool verdaderoFalse = false;
    //variable para almacenar texti
    private string cadenaTexto = "hola";
    //variable para almacenar letras

    private char letra = 'a';

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeroEntero = 37;

        cadenaTexto = "Hola Mundo";

        Debug.Log(cadenaTexto);

         Calculo();
    }

    void Calculo()
    {
       numeroEntero = 7 + 5;
       numeroEntero = 6 * 9;
       numeroEntero = 2 - 7;
       numeroEntero = 4 / 3;   

       numeroEntero = numeroEntero + 2;
       numeroEntero += 4;
       numeroEntero -= 3;
       numeroEntero++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
