using System;

namespace Math_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            string MathematicalObject;

            double VolumeOfCylinder;
            double AreaOfCylinder;
            string InputCylinderHeight;   //I first make a string out of the user input then i convert it into a double
            string InputCylinderRadius;
            double SquaredCylinderRadius;

            double VolumeOfPyramid;
            string InputPyramidHeigth;
            string InputPyramidLength;
            string InputPyramidWidth;

            double VolumeOfSphere;
            double AreaOfSphere;
            double SphereRadius;
            string InputSphereRadius;
            double SquaredSphereRadius;
            double SquaredSphereRadiusThird;

            string unit;

            double pi;
            pi = System.Math.PI;
            //pi = System.Math.Atan(1)*4.0;



            Console.WriteLine("You can choose from different objects you want to find the area and volume : cylinder, ball, pyramid \n ");

            Console.Write("Enter the object : ");
            MathematicalObject = Console.ReadLine();
            Console.Write("Enter the unit : ");
            unit = Console.ReadLine();

            if (MathematicalObject == "cylinder")
            {
                Console.Write("Enter the cylinder's height : ");
                InputCylinderHeight = Console.ReadLine();
                double CylinderHeight = Convert.ToDouble(InputCylinderHeight);

                

                Console.Write("Enter the cylinder's radius : ");
                InputCylinderRadius = Console.ReadLine();
                double CylinderRadius = Convert.ToDouble(InputCylinderRadius);

                

                SquaredCylinderRadius = Math.Pow(CylinderRadius, 2);

                VolumeOfCylinder = pi * SquaredCylinderRadius * CylinderHeight;
                AreaOfCylinder = 2.0 * pi * CylinderRadius * (CylinderRadius + CylinderHeight);


                Console.WriteLine("The cylinder's volume is : " + VolumeOfCylinder + " " + unit + "^3 \nThe cylinder's area is : " + AreaOfCylinder + " " + unit + "^2");
                Console.ReadLine();

            }





            if (MathematicalObject == "pyramid")
            {
                Console.Write("Enter the pyramid's height : ");
                InputPyramidHeigth = Console.ReadLine();
                double PyramidHeight = Convert.ToDouble(InputPyramidHeigth);

                Console.Write("Enter the pyramid's length : ");
                InputPyramidLength = Console.ReadLine();
                double PyramidLength = Convert.ToDouble(InputPyramidLength);

                Console.Write("Enter the pyramid's width : ");
                InputPyramidWidth = Console.ReadLine();
                double PyramidWidth = Convert.ToDouble(InputPyramidWidth);



                VolumeOfPyramid = PyramidLength * PyramidWidth * PyramidHeight / 3.0;


                Console.WriteLine("The pyramid's volume is = " + VolumeOfPyramid + " " + unit + "^3");
                Console.ReadLine();

            }


            if (MathematicalObject == "sphere")
            {

                Console.Write("Enter the sphere's radius : ");
                InputSphereRadius = Console.ReadLine();

                SphereRadius = Convert.ToDouble(InputSphereRadius);

                SquaredSphereRadius = Math.Pow(SphereRadius, 2);
                SquaredSphereRadiusThird = Math.Pow(SphereRadius, 3);


                VolumeOfSphere = 4.0 / 3.0 * pi * SquaredSphereRadiusThird;
                AreaOfSphere = 4.0 * pi * SquaredSphereRadius;

                Console.WriteLine("The volume of the sphere is = " + VolumeOfSphere + " " + unit + "^3  \nThe Area of the sphere is = " + AreaOfSphere + " " + unit + "^2");

                //var b = new Sphere(BallRadius);
                //Console.WriteLine($"Volume {b.Volume()}");
                //Console.WriteLine($"Area {b.Area()}");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("\nError invalid object");
                Console.ReadLine();
            }
















        }
    }
}