using System;

namespace AnimalLibrary {
    public enum MuzzleType { Long, Short, Collapsed};
    public enum PitchType { High, Medium, Low};
    public class Dog {
        public bool LongTail { get; set; }
        public PitchType BarkPitch { get; set; } // high, medium, low
        public MuzzleType Muzzle { get; set; } // long, short, collapsed
        public bool ExtremeSenseofSmell { get; set; } = false;
        public string Name { get; set;}
        public Dog() {

        }
        public Dog(string Name) {
            this.Name = Name;
        }
    }
}