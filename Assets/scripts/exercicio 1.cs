using UnityEngine;

public class exercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 5; i > 0; i--)
        {
            print(i);
        }
        print("Início da partida!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//1. (Contagem regressiva de tempo) Crie uma contagem
//regressiva de 5 a 1 e exiba "Início da partida!" ao final.