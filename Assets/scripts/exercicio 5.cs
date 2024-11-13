using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    [SerializeField] int dificuldade = 0;
    void Start()
    {
        for (int fase = 1; fase <= 6; fase++)
        {
            dificuldade += 5;
            print ("fase" + fase +  " dificuldade da fase é : " + dificuldade);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//5. (Aumento de nível de dificuldade) A cada fase completada, a
//dificuldade aumenta em 5 pontos.Exiba a dificuldade após cada
//fase, em um total de 6 fases.
