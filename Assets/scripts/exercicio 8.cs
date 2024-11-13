using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    string palavra = "thiago";

    string invertida = "";

    void Start()
    {
        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            invertida += palavra[i];
        }

        print("String invertida: " + invertida);
    }

    
    void Update()
    {
        
    }
}
