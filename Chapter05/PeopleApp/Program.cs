using System;
using System.Collections.Generic;
using Packt.Shared;
using static System.Console;

namespace PeopleApp {
    class Program {
        static void Main(string[] args) {
            var bob = new Person();
            bob.Name = "Bob";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.ColosusOfRhodes;
            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon |
                WondersOfTheAncientWorld.ColosusOfRhodes;
            // bob.BucketList = (WondersOfTheAncientWorld)18;
            bob.Childred = new List<Person> {
                new Person { Name = "Zoe" },
                new Person { Name = "Alfred" }
            };
            (string, int) fruit = bob.GetFruit();
            var fruitByName = bob.GetFruitByName();
            (string fruitName, int fruitCount) = bob.GetFruit();
            
            WriteLine(
                format: "{0} - {1}",
                arg0 : fruit.Item1,
                arg1 : fruit.Item2
            );
            WriteLine(
                format: "By name: {0} - {1}",
                arg0 : fruitByName.Name,
                arg1 : fruitByName.Count
            );
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}. Favorite wonder: {2}",
                arg0 : bob.Name,
                arg1 : bob.DateOfBirth,
                arg2 : bob.FavoriteAncientWonder
            );
            WriteLine(
                format: "Favorite wonders: {0}",
                arg0 : bob.BucketList
            );
            WriteLine(
                format: "Childrens: {0}",
                arg0 : bob.Childred
            );
        }
    }
}