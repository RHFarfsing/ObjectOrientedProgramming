using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog{
        public Boxer(string Name) : base(Name) {
            this.BarkPitch = PitchType.Medium;
            this.Muzzle = MuzzleType.Collapsed;
        }
        public Boxer() {

        }
    }
}
