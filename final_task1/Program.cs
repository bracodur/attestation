﻿//Задача: Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


using System.ComponentModel.DataAnnotations;

string[] town = ["Tomsk", "Omsk", "Penza", "Kursk", "No", "NSK"];
string[] sym3 = ["A"];
int  i, i3;

for ( i = 0, i3 = 0; i < town.Length; i++ )
{
  if ( town[i].Length <= 3 )
  {
    if ( i3 > 0 )
    {
      Array.Resize(ref sym3, i3+1);
    }
    sym3[i3] = town[i];
    i3++;
  }
}

for ( i = 0; i < sym3.Length; i++ )
{
  Console.WriteLine(sym3[i]);
}