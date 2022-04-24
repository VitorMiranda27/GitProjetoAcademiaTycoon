using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static int Dinheiro = 0;
    public Text textMoney;

    public void Start()
    {
        Money.Dinheiro = 500; //Dinheiro inicial
    }

    void FixedUpdate()
    {
        textMoney.text = "Dinheiro: " + Money.Dinheiro;
    }

    public static void AttDinheiro(int QtdDinheiro)
    {
        if (QtdDinheiro < 0 && Money.Dinheiro <= 0)
        {

        }
        else
        {
            Money.Dinheiro += QtdDinheiro;   //Adiciona dinheiro negativo no caso de uma opera��o de compra, posso fazer de outra forma tamb�m, se acharem melhor.
        }
        
    }

}
