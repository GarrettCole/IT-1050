using System;
namespace ConsoleApp3
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        double TotalWeight = 0;
        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            for (int i = 0; i < Occupants.Length; i++)
            { TotalWeight += Occupants[i].GetWeight(); }
            return TotalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (MaxWeight < GetCurrentWeight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
