﻿using System;

Console.WriteLine("Ведите число");

string input = Console.ReadLine ();

int number = int.Parse (input);

int square = number * number;

Console.WriteLine ($"Число в квадрате равно {square}");

