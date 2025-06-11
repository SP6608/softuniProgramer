using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsRegularExam
{
    public class Farm
    {

        private string name;
        private List<Animal> animals;

        public Farm(string name)
        {
            this.Name = name;
            this.Animals = new List<Animal>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public List<Animal> Animals
        {
            get
            {
                return this.animals;
            }
            set
            {
               this.animals = value;
            }
        }

        public void AddAnimal(string type, int weight)
        {
            Animal animal=new Animal(type,weight);
            this.Animals.Add(animal);
        }

        public double AverageWeight()
        {
            return Animals.Average(x => x.Weight);
        }

        public List<string> FilterAnimalsByWeight(int weight)
        {
            var tempList= Animals.Where(x => x.Weight < weight).ToList();
            List<string> list= new List<string>();
            foreach (var animal in tempList) 
            { 
               list.Add(animal.Type.ToString());
            }
            return list;
        }


        public List<Animal> SortAscendingByType()
        {
            this.Animals= Animals.OrderBy(x=>x.Type).ToList();
            return this.Animals;
        }

        public List<Animal> SortDescendingByWeight()
        {
            this.Animals= Animals.OrderByDescending(x=>x.Weight).ToList();
            return this.Animals;
        }

        public bool CheckAnimalIsInFarm(string type)
        {
            return Animals.FirstOrDefault(x => x.Type == type) != null;
        }

        public string[] ProvideInformationAboutAllAnimals()
        {
            string[]tempArray=new string[Animals.Count];
            for (int i = 0; i < Animals.Count; i++)
            {
                tempArray[i] = Animals[i].ToString() + Environment.NewLine;
            }
            return tempArray;
        }
    }
}

