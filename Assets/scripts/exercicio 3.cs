using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    [SerializeField] int totalmoedas = 0;
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            totalmoedas += 3;
            print( "o taltal de moedas agora é de " + totalmoedas );
        }

        print("o total de moedas é " + totalmoedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//3. (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
// cada fase.Após 10 fases, exiba o total de moedas coletadas.


