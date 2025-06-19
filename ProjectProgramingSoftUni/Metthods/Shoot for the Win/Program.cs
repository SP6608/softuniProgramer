namespace Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int brTargets = 0;

            while (command != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < targets.Count && targets[index] != -1)
                {
                    int shootValue = targets[index];
                    targets[index] = -1;
                    brTargets++;

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] == -1) continue;

                        if (targets[i] > shootValue)
                        {
                            targets[i] -= shootValue;
                        }
                        else
                        {
                            targets[i] += shootValue;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {brTargets} -> {string.Join(' ', targets)}");
        }
    }
}
