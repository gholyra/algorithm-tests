using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonScript : MonoBehaviour
{
    /*Com SerializeField, a variável irá aparecer na interface da Unity
    para que possa ser vista e/ou alterada através da própria engine*/
    [SerializeField] private int number;
    [SerializeField] private int number2;

    // Start is called before the first frame update
    void Start()
    {
        //print("Multiplicação: " + (number * number2));
        //print("Soma: " + (number + number2));
        //print("Subtração: " + (number2 - number2));
        //print("Divisão: " + (number / number2));
        //
        /*
        if(number == number2)
        {
            print("Os valores são iguais");
        }
        else if(number <= number2)
        {
            print("O segundo valor é maior ou igual ao primeiro valor");
        }
        else if(number >= number2)
        {
            print("O primeiro valor é maior ou igual ao segundo valor");
        }

        //As duas condições devem ser verdadeiros
        if(number > number2 && number % 2 == 0)
        {
            print("O primeiro número é maior que o segundo, E é um número par");
        }
        //Uma condição OU outra devem ser verdadeiras
        else if(number > number2 || number % 2 == 0)
        {
            print("O primeiro número é maior que o segundo, OU é um número par");
        }
        */
        //
        //number = number + 1;
        //number += 1;
        //number++;
        while(number < number2)
        {
            print("O primeiro número tem o valor de " + number2);
            number2--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
