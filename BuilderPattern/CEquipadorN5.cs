using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CEquipadorN5 : ACEquipable
    {
        public CEquipadorN5() : base()
        {
        }

        public override void EquiparArma()
        {
            base._monstruo.Add("Espada +5");
        }

        public override void EquiparArmadura()
        {
            base._monstruo.Add("Armadura +5");
        }

        public override void EquiparPociones()
        {
            base._monstruo.Add("Pociones Nivel 5");
        }
    }
}