using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonScript : MonoBehaviour
{
    /*Com SerializeField, a vari�vel ir� aparecer na interface da Unity
    para que possa ser vista e/ou alterada atrav�s da pr�pria engine*/
    [SerializeField] private int number;
    [SerializeField] private int number2;

    // Start is called before the first frame update
    void Start()
    {
        //print("Multiplica��o: " + (number * number2));
        //print("Soma: " + (number + number2));
        //print("Subtra��o: " + (number2 - number2));
        //print("Divis�o: " + (number / number2));
        //
        /*
        if(number == number2)
        {
            print("Os valores s�o iguais");
        }
        else if(number <= number2)
        {
            print("O segundo valor � maior ou igual ao primeiro valor");
        }
        else if(number >= number2)
        {
            print("O primeiro valor � maior ou igual ao segundo valor");
        }

        //As duas condi��es devem ser verdadeiros
        if(number > number2 && number % 2 == 0)
        {
            print("O primeiro n�mero � maior que o segundo, E � um n�mero par");
        }
        //Uma condi��o OU outra devem ser verdadeiras
        else if(number > number2 || number % 2 == 0)
        {
            print("O primeiro n�mero � maior que o segundo, OU � um n�mero par");
        }
        */
        //
        //number = number + 1;
        //number += 1;
        //number++;
        while(number < number2)
        {
            print("O primeiro n�mero tem o valor de " + number2);
            number2--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
