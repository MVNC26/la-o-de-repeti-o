using UnityEngine;

public class exercico4 : MonoBehaviour
{
    [SerializeField] int comboponto = 0;
    void Start()
    {
        for (int i = 1; i <= 7; i++) 
        {
            comboponto += 10;
            print ( "a sua pontua��o de combo � agora de " + ":" + comboponto );

        }
        
        print("sua pontua��o final de combo � " + ":" + comboponto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//4. (Pontua��o em combos) Cada combo realizado aumenta em 10
//pontos.Exiba a pontua��o total ap�s 7 combos.
