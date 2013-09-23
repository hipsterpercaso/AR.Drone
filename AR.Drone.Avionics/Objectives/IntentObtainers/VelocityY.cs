﻿using System;

using AR.Drone.Avionics.Tools;
using AR.Drone.Avionics.Apparatus;

namespace AR.Drone.Avionics.Objectives.IntentObtainers
{
    public class VelocityY : VelocityIntent
    {
        public VelocityY(float aValue, float aAgression = Intent.DefaultAgression) : base(aValue, aAgression) { /* Do Nothing */ }
        public override void Contribute(Apparatus.Output aApparatusOutput, ref Apparatus.Input aApparatusInput)
        {
            aApparatusInput.Roll = CalculateVelocityManeuver(aApparatusOutput.Navigation.Velocity.Y);
        }
    }
}
