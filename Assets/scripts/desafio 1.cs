using UnityEngine;

public class desafio1 : MonoBehaviour
{

    [SerializeField] string texto = "JOGOS digitais";
    [SerializeField] int contadorConsoantes; 

    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(letra)))
            {
                contadorConsoantes++;
            }

        }

        print("O n�mero de consoantes �: " + contadorConsoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
