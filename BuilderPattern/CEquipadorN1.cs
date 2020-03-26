using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CEquipadorN1 : ACEquipable
    {
        public CEquipadorN1() : base()
        {
        }

        public override void EquiparArma()
        {
            base._monstruo.Add("Espada +1");
        }

        public override void EquiparArmadura()
        {
            base._monstruo.Add("Armadura +1");
        }

        public override void EquiparPociones()
        {
            base._monstruo.Add("Pociones Nivel 1");
        }
    }
}