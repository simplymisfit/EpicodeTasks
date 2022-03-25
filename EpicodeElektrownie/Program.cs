using EpicodeElektrownie;
public class Program
{

    public static void Main()
    {
        /*
        public int Identifier { get; set; }
        public int AvailableEnergy { get; set; }
        public List<int> Neighbours { get; set; }
        */
        //zapisac ile energii moze dostarczyc cala infrastruktura
        //jest N elektrowni, ktore sa ze soba polaczone
        //nie zawsze jest droga bezposrednia

        //firstPowerStation to jedyna informacja i jest to elektrownia z ktorej zaczyna inzynier

        PowerPlant firstPowerStation = new PowerPlant(1, 100, new List<PowerPlant>());
        PowerPlant powerPlant2 = new PowerPlant(2, 200, new List<PowerPlant>());
        PowerPlant powerPlant3 = new PowerPlant(3, 300, new List<PowerPlant>());
        PowerPlant powerPlant4 = new PowerPlant(4, 400, new List<PowerPlant>());
        PowerPlant powerPlant5 = new PowerPlant(5, 500, new List<PowerPlant>());
        PowerPlant powerPlant6 = new PowerPlant(6, 600, new List<PowerPlant>());

        firstPowerStation.Neighbours.Add(powerPlant2);
        firstPowerStation.Neighbours.Add(powerPlant3);
        firstPowerStation.Neighbours.Add(powerPlant4);
        firstPowerStation.Neighbours.Add(powerPlant5);
        firstPowerStation.Neighbours.Add(powerPlant6);

        powerPlant2.Neighbours.Add(firstPowerStation);
        powerPlant2.Neighbours.Add(powerPlant3);
        powerPlant2.Neighbours.Add(powerPlant4);
        powerPlant2.Neighbours.Add(powerPlant5);
        powerPlant2.Neighbours.Add(powerPlant6);

        powerPlant3.Neighbours.Add(firstPowerStation);
        powerPlant3.Neighbours.Add(powerPlant2);
        powerPlant3.Neighbours.Add(powerPlant4);
        powerPlant3.Neighbours.Add(powerPlant5);
        powerPlant3.Neighbours.Add(powerPlant6);

        powerPlant4.Neighbours.Add(firstPowerStation);
        powerPlant4.Neighbours.Add(powerPlant2);
        powerPlant4.Neighbours.Add(powerPlant3);
        powerPlant4.Neighbours.Add(powerPlant5);
        powerPlant4.Neighbours.Add(powerPlant6);

        powerPlant5.Neighbours.Add(firstPowerStation);
        powerPlant5.Neighbours.Add(powerPlant2);
        powerPlant5.Neighbours.Add(powerPlant3);
        powerPlant5.Neighbours.Add(powerPlant4);
        powerPlant5.Neighbours.Add(powerPlant6);

        powerPlant6.Neighbours.Add(firstPowerStation);
        powerPlant6.Neighbours.Add(powerPlant2);
        powerPlant6.Neighbours.Add(powerPlant3);
        powerPlant6.Neighbours.Add(powerPlant4);
        powerPlant6.Neighbours.Add(powerPlant5);


        /*        firstPowerStation.Neighbours.Add(powerPlant2);
                firstPowerStation.Neighbours.Add(powerPlant3);

                powerPlant2.Neighbours.Add(firstPowerStation);
                powerPlant2.Neighbours.Add(powerPlant4);

                powerPlant3.Neighbours.Add(firstPowerStation);
                powerPlant3.Neighbours.Add(powerPlant4);
                powerPlant3.Neighbours.Add(powerPlant5);

                powerPlant4.Neighbours.Add(powerPlant3);
                powerPlant4.Neighbours.Add(powerPlant5);

                powerPlant5.Neighbours.Add(powerPlant4);
                powerPlant5.Neighbours.Add(powerPlant6);

                powerPlant6.Neighbours.Add(powerPlant5);*/

        Program program = new Program();
        Console.WriteLine(program.SumOfPower(firstPowerStation));
    }



    public int SumOfPower(PowerPlant firstPowerStation)
    {
        int sum = 0;

        Stack<PowerPlant> stack = new Stack<PowerPlant>();
        var visited = new HashSet<PowerPlant>();

        stack.Push(firstPowerStation);
        while (stack.Count != 0)
        {
            var current = stack.Pop();
            for (int i = 0; i < current.Neighbours.Count; i++)
            {
                if (!visited.Contains(current.Neighbours[i]))
                {
                    stack.Push(current.Neighbours[i]);
                }
            }
            if (!visited.Add(current))
                continue;

            sum += current.AvailableEnergy;
        }
        return sum;
    }
}

