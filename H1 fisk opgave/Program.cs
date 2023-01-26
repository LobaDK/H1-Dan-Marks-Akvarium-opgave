using System.ComponentModel.Design;

namespace H1_fisk_opgave
{
    internal class Program
    {
        static List<Fisk> fishList = new List<Fisk>();
        static List<Aquarium> aquariaList = new List<Aquarium>();
        static Fisk fish = new Fisk();
        static void Main(string[] args)
        {
            // Menu:
            // Add fish
            // Add aquarium
            // List fish
            // View specific fish - only show valid aquarium
            // List aquarium
            // View specific aquarium
            // Delete fish
            // Delete aquarium - Also delete fish in deleted aquarium

            for (int i = 0; i < 3; i++)
            {
                fish.Name = "Name";
                fish.FishTank = i.ToString();
                fish.Size = "medium";
                fish.IsCarnivore = false;
                fish.RequiresSaltWater = true;

                fishList.Add(fish);
            }

            while (true)
            {
                Console.WriteLine("\nMain Menu\n\n(1) Add fish\n(2) Add aquarium\n(3) List fish\n(4) View fish\n(5) List aquarium\n(6) View aquarium\n(7) Remove fish\n(8) Remove aquarium");
                var v = Console.ReadKey(true);
                switch (v.KeyChar)
                {
                    case '1':
                        AddFish();
                        break;
                    case '2':
                        AddAquarium();
                        break;
                    case '3':
                        ListFish();
                        break;
                    case '4':
                        ViewFish();
                        break;
                    case '5':
                        ListAquarium();
                        break;
                    case '6':
                        ViewAquarium();
                        break;
                    case '7':
                        RemoveFish();
                        break;
                    case '8':
                        RemoteAquarium();
                        break;
                }
            }
        }

        private static void RemoteAquarium()
        {
            throw new NotImplementedException();
        }

        private static void RemoveFish()
        {

            Console.WriteLine("Delete");
            ListFish();
            Console.Write("Enter task number to delete: ");
            fishList.RemoveAt(SelectIndex());
            Console.WriteLine("Task deleted!");

        }

        private static void ViewAquarium()
        {
            throw new NotImplementedException();
        }

        private static void ListAquarium()
        {
            throw new NotImplementedException();
        }

        private static void ViewFish()
        {

            ListFish();
            int input = SelectIndex();
            Console.WriteLine($"Fish Name: {fishList[input].Name} \nFish Tank: {fishList[input].FishTank} \nFish Size: {fishList[input].Size} \nEats Meat: {fishList[input].IsCarnivore} \nRequires Salt Water: {fishList[input].RequiresSaltWater}");

        }

        private static int SelectIndex()
        {
            int index;

            do
            {
                Console.WriteLine("Choose Fish from list:");

            } while (!int.TryParse(Console.ReadLine(), out index) || index >= fishList.Count);

            return index;
        }

        private static void ListFish()
        {
            if (fishList.Count > 0)
            {
                Console.WriteLine("\n");
                for (int i = 0; i < fishList.Count; i++)
                {
                    Console.WriteLine($"[{i}] {fishList[i].Name}");
                }
            }
            else Console.WriteLine("No fish available");
        }

        private static void AddAquarium()
        {
            throw new NotImplementedException();
        }

        private static void AddFish()
        {
            Console.WriteLine("Fish name: ");
            fish.Name = Console.ReadLine();
            Console.WriteLine("Fish Tank: ");
            fish.FishTank = Console.ReadLine();
            Console.WriteLine("Fish Size: ");
            fish.Size = Console.ReadLine();
            Console.WriteLine("Does it eat Meat: ");
            fish.IsCarnivore = True_or_False_Checker();
            Console.WriteLine("Does it Require Salt Water: ");
            fish.RequiresSaltWater = True_or_False_Checker();
            fishList.Add(fish);

        }

        private static bool True_or_False_Checker()
        {
            string input;
            do
            {
                input = Console.ReadLine();

            } while (input == null || input != "y" && input != "n");

            if (input == "y")
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