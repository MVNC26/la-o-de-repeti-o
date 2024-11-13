using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < 10000; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                print("fiz buzz");
            }
            else if (i % 5 == 0)
            {
                print("buzz");
            }
            else if (i % 3 == 0)
            {
                print("fizz");
            }
            else
            {
                print(i);            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

 //(Fizz Buzz) Para cada número entre 0 e 10000, escreva apenas
    //“fizz” no console quando for divisível por 3, “buzz” quando for
    //divisível por 5 e “fizz buzz” quando for divisível pelos dois.Se o
    //número não for divisível por nenhum deles, escreva-o no console.

