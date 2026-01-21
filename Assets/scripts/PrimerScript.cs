using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    private int numeroEntero = 5;
    private float numeroDecimal = 7.5f;
    private bool verdaderoFalse = false;
    private string cadenaTexto = "hola";
    private char letra = 'a';
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        numeroEntero = 37;

        cadenaTexto = "hola Mundo";

        Debug.Log(cadenaTexto + "adios");
        Debug.Log(numeroEntero);

        Calcule();

    }

    void Calcule()
    {
        numeroEntero = 7 + 5;
        numeroEntero = 2 - 7;
        numeroEntero = 6 * 9;
        numeroEntero = 4 / 3;

        numeroEntero = numeroEntero + 2;
        numeroEntero++;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
