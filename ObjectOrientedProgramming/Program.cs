using System;
using AnimalLibrary;

namespace ObjectOrientedProgramming {
    class Program {
        static void Main(string[] args) {
            var gs1 = new GermanShephard("Killer");
            //var germansheperd = new AnimalLibrary.Dog();
            var germanshepard = new GermanShephard {
                LongTail = true,
                BarkPitch = PitchType.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseofSmell = true,
                BigDog = true,
                Name = "Fred"
                
            };
            var pug1 = new Pug("Steve");
            var pug2 = new Pug();
            var pug = new Dog {
                LongTail = false,
                BarkPitch = PitchType.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseofSmell = false,
                Name = "Ralph"
            };
            var boxer1 = new Boxer("Tyson");
        }
    }
}