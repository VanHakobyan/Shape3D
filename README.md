# Shape3D
Shape3D in have ellipsoidal , dimensional and parallelogram

<p align="center">
<img src="https://upload.wikimedia.org/wikipedia/commons/c/c1/120-cell-inner.gif">
</p>
<p align="left">
<img src="http://www.ditutor.com/solid_gometry/images/r.gif">
</p>

<p align="right">
<img src="http://evlm.stuba.sk/~velichova/Matematika2/Kniha/Kapitola2/Images1/obl2.gif">
</p>



```csharp
            ellipsoidal elips = new ellipsoidal(5, 1.2f, 8, 1200); //parameters
            Console.WriteLine(elips.areaGet());    // area ellipsoidal
            Console.WriteLine(elips.massGet());    // mass ellipsoidal
            Console.WriteLine(elips.volumeGet());  // volume ellipsoidal
            elips.MoveBy(5f, 1.5f, 4.1f);//axis movement
            elips.MoveTo(6.7f, 4f, 3f);  //axis movement

            parallelogram paral = new parallelogram(1.5f, 5, 15, 800); //parameters
            Console.WriteLine(paral.areaGet());     //area parallelogram
            Console.WriteLine(paral.massGet());     //mass parallelogram
            Console.WriteLine(paral.volumeGet());   //volume parallelogram
            paral.MoveBy(4.1f, 4f, 2.9f);//axis movement
            paral.MoveTo(5.3f,1.1f,3.8f);//axis movement
            
            ```
            
