﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMovie = new Movies("Casino Royale", "Eon Productions", "PG­13");
            var secondMovie = new Movies("Glass", "Buena Vista International", "PG­13");
            var thirdMovie = new Movies("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");




            var movies = new List<Movies>();
            movies.Add(new Movies("Casino Royale", "Eon Productions", "PG­13"));
            movies.Add(new Movies("Glass", "Buena Vista International", "PG­13"));
            movies.Add(new Movies("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG"));

            foreach (var item in movies)
            {
                Console.WriteLine(item.);
            }

        }
    }
}