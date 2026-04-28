using SF_BaseTypesControls;
using System.Reflection;
using System.Text;
using System;
using System.Collections.Generic;

namespace StreetFighter_2ITC
{
    public class MinigameLoader
    {
        public static List<Type> LoadedMinigames = new List<Type>();
        public static List<Type> AllMinigames = new List<Type>();

        public void LoadDefaultMinigameTypes()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            AllMinigames.AddRange(LoadMinigamesFromAssembly(ass));
        }

        public void LoadMinigamesFromFile(string fileDll)
        {
            Assembly loaded = Assembly.LoadFrom(fileDll);
            AllMinigames.AddRange(LoadMinigamesFromAssembly(loaded));
        } 

        private List<Type> LoadMinigamesFromAssembly(Assembly ass)
        {
            var types = ass.GetTypes().ToList();
            var filtered = types.Where(t => t.IsAssignableTo(typeof(IMinigame)) && !t.IsAbstract && t.IsClass);

            Debug.WriteLine(string.Join<Type>("\n", filtered));

            return filtered.ToList();
            //availableMinigames.AddRange(filtered);
        }
    }
}