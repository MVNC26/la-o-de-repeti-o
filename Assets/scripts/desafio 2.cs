using System;
using UnityEngine;

public class desafio2 : MonoBehaviour
{
    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;

    void Start()
    {
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        ////Calcular ano vividos
        //int anosVividos = anoAtual - anoNascimento;

        ////Calcular meses vividos
        //int mesesVividos = mesAtual - mesNascimento;

        //if(mesesVividos < 0)
        //{
        //    anosVividos--;
        //    //mesesVividos = mesesVividos + 12;
        //    mesesVividos += 12;
        //}

        ////Calcular dias vividos
        //int diasVividos = diaAtual - diaNascimento;

        //if(diasVividos < 0)
        //{
        //    mesesVividos--;
        //    diasVividos += 30;

        //    if(mesesVividos < 0)
        //    {
        //        anosVividos--;

        //        //mesesVividos = mesesVividos + 12;
        //        mesesVividos += 12;
        //    }
        //}

        //print("Voc� viveu: " +  diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos");

        //total de dias vividos
        int totalDiasVividos = (anoAtual - anoNascimento) * 365 + (mesAtual - mesNascimento) * 30 + (diaAtual - diaNascimento);

        //Converte para anos, meses e dias restantes
        int anosVividos = totalDiasVividos / 365;
        int mesesVividos = (totalDiasVividos % 365) / 30;
        int diasVividos = (totalDiasVividos % 365) % 30;

        print("Voc� viveu: " + diasVividos + " dias, " + mesesVividos + " meses, " + anosVividos + " anos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
