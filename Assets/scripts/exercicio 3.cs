using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    [SerializeField] int totalmoedas = 0;
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            totalmoedas += 3;
            print( "o taltal de moedas agora � de " + totalmoedas );
        }

        print("o total de moedas � " + totalmoedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//3. (C�lculo de moedas coletadas) O jogador coleta 3 moedas a
// cada fase.Ap�s 10 fases, exiba o total de moedas coletadas.


