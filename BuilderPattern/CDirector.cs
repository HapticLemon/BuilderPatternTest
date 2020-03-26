using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class CDirector
    {
        private ACEquipable _builderN1;
        private ACEquipable _builderN5;
        private ACEquipable _builderN10;

        public ACEquipable BuilderN1
        {
            set { _builderN1 = value; }
           
        }

        public ACEquipable BuilderN5
        {
            set { _builderN5 = value; }
        }

        public ACEquipable BuilderN10
        {
            set { _builderN10 = value; }
        }


        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViableMonsterN1()
        {
            this._builderN1.EquiparArma();
        }

        public void buildMinimalViableMonsterN5()
        {
            this._builderN5.EquiparArma();
        }

        public void buildMinimalViableMonsterN10()
        {
            this._builderN10.EquiparArma();
        }

        public void buildFullFeaturedMonsterN1()
        {
            this._builderN1.EquiparArma();
            this._builderN1.EquiparArmadura();
            this._builderN1.EquiparPociones();
        }

        public void buildFullFeaturedMonsterN5()
        {
            this._builderN5.EquiparArma();
            this._builderN5.EquiparArmadura();
            this._builderN5.EquiparPociones();
        }

        public void buildFullFeaturedMonsterN10()
        {
            this._builderN10.EquiparArma();
            this._builderN10.EquiparArmadura();
            this._builderN10.EquiparPociones();
        }
    }
}