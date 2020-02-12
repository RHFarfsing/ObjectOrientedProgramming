using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class GermanShephard : Dog{
        public bool BigDog { get; set; } = true;
        public GermanShephard(string Name) : base(Name) {
            this.BarkPitch = PitchType.Low;
            this.Muzzle = MuzzleType.Long;

        }
        public GermanShephard() {
        }
        public override string GetTypeOfDog() {
            return "German Shephard";
        }
    }
}
