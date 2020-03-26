using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CEquipadorN10 : ACEquipable
    {
        public CEquipadorN10() : base()
        {
        }

        public override void EquiparArma()
        {
            base._monstruo.Add("Espada +10");
        }

        public override void EquiparArmadura()
        {
            base._monstruo.Add("Armadura +10");
        }

        public override void EquiparPociones()
        {
            base._monstruo.Add("Pociones Nivel 10");
        }
    }
}