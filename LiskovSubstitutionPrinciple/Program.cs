using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public interface ITurnable
    {
        void TurnRight();
        void TurnLeft();
    }
    public interface IMovable
    {
        void GoForward();
        void GoBackward();
    }

    public class RoadVehicle : IMovable, ITurnable
    {
        public float speed = 50f;
        public float turnSpeed = 2f;

        public virtual void GoForward()
        {

        }

        public virtual void GoBackward()
        {

        }

        public virtual void TurnLeft()
        {

        }

        public virtual void TurnRight()
        {

        }

    }
    public class RailVehicle : IMovable
    {
        public float speed = 30f;

        public virtual void GoForward()
        {

        }

        public virtual void GoBackward()
        {

        }
    }
    public class Car : RoadVehicle
    {
        //...
    }

    public class Truck : RoadVehicle
    {
        //...
    }

    public class Train : RailVehicle
    {
        //...
    }

    public class Tram : RailVehicle
    {
        //...
    }


    // Bad Design

    /*
     
    public class Vehicle
    {
        public float speed = 10f;

        public void GoForward()
        {

        }
        public void Reverse()
        {

        }
        public void TurnRight()
        {
               
        }
        public void TurnLeft()
        {

        }
    }

    public class Car : Vehicle
    {

    }

    public class Train : Vehicle
    {   
        // No need for TurnLeft and TurnRight on the train
    }

    */

}
