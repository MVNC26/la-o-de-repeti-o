using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    [SerializeField] int Dano = 10;
    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            print("o dano dado � de " + i + ":Dano " + Dano);

            Dano += 2;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//2. (Multiplica��o de dano) Um personagem ataca cinco vezes, e o
//dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
//ataque.