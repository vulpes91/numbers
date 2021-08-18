using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    int minimalGuess;
    int maximalGuess;
    int myGuess;

    // Start is called before the first frame update
    void Start()
    {        
       ShowIntro();
       StartGame(); 
    }

    void ShowIntro () {
        Debug.Log("Работает!");
    }

    //void - значит не возвращает ничего 
    // StartGame - имя функции,  ЧТО делать? 
    // () - параметры ()=пустой 
    //{ утверждения внутри фигурных скобок}
    void StartGame() 
    {
        maximalGuess = 500;
        minimalGuess = 1;
        myGuess = 250;

        print ("Добро пожаловать в Угадыватель цифр-2000! Выберите число в указанном диапазоне: ");
        Debug.Log("Минимальное число, которое вы можете выбрать, это " + minimalGuess + " Максимальное число, которое вы можете выбрать, это " + maximalGuess);
        Debug.Log("Ваше число больше или меньше, чем " + myGuess + "?");
        Debug.Log("Нажмите Вверх если число больше. Нажмите Вниз если число меньше.Нажмите Enter если я угадал загаданное число.Нажмите H(h) для подсказки");
        maximalGuess=maximalGuess+1;
    }

    // Update is called once per frame 
    void Update() {
         if (Input.GetKeyDown(KeyCode.UpArrow))
         {
            minimalGuess = myGuess;
            NextGuess();
         }

         else if (Input.GetKeyDown(KeyCode.DownArrow))
         {
            maximalGuess = myGuess;
            NextGuess();
         }

         else if (Input.GetKeyDown(KeyCode.Return))
         {
             Debug.Log("Отлично, я угадал!");
             StartGame();
         }

         else if (Input.GetKeyDown(KeyCode.H))
         {
             Debug.Log("Стрелка вверх, если ваше число больше");
             Debug.Log("Стрелка вниз, если ваше число меньше");
             Debug.Log("Enter если я угадал");
             Debug.Log("H(h) если забыли кнопки");
         }
    } 

    void NextGuess(){
        myGuess = (maximalGuess+minimalGuess)/2;
        Debug.Log("Ваше число больше или меньше, чем  " + myGuess + "?");
    }
}
