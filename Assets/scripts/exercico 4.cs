using UnityEngine;

public class exercico4 : MonoBehaviour
{
    [SerializeField] int comboponto = 0;
    void Start()
    {
        for (int i = 1; i <= 7; i++) 
        {
            comboponto += 10;
            print ( "a sua pontuação de combo é agora de " + ":" + comboponto );

        }
        
        print("sua pontuação final de combo é " + ":" + comboponto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//4. (Pontuação em combos) Cada combo realizado aumenta em 10
//pontos.Exiba a pontuação total após 7 combos.
