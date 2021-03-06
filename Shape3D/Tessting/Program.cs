﻿using dimensionalClass;
using System;

namespace Tessting
{
    class Program
    {
        static void Main(string[] args)
        {

            ellipsoidal elips = new ellipsoidal(5, 1.2f, 8, 1200); //parameters
            Console.WriteLine(elips.areaGet());    // area ellipsoidal
            Console.WriteLine(elips.massGet());    // mass ellipsoidal
            Console.WriteLine(elips.volumeGet());  // volume ellipsoidal
            elips.MoveBy(5f, 1.5f, 4.1f);            // moveing BY
            elips.MoveTo(6.7f, 4f, 3f);              // moveing to

            parallelepiped paral = new parallelepiped(1.5f, 5, 15, 800); //parameters
            Console.WriteLine(paral.areaGet());     //area parallelogram
            Console.WriteLine(paral.massGet());     //mass parallelogram
            Console.WriteLine(paral.volumeGet());   //volume parallelogram
            paral.MoveBy(4.1f, 4f, 2.9f);          // moveing BY
            paral.MoveTo(5.3f,1.1f,3.8f);            // moveing to

        } 
    }
}
