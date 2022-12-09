using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Szerepjatek
{
    interface ICharacter
    {

    }

    interface IFighter:ICharacter
    {

    }

    interface IMage:ICharacter
    {

    }

    class BattleMage:IFighter, IMage
    {

    }

    class Fighter:IFighter
    {
        int weaponSkill;
        public Fighter(int weaponSkill)
        {
            if(weaponSkill >= 1 && weaponSkill <= 100)
            {
                this.weaponSkill = weaponSkill;
            }
        }
    }

    class Mage:IMage
    {
        int castingSkill;
        int mana;
        public Mage(int castingSkill, int mana)
        {
            if (castingSkill >= 1 && castingSkill <= 100)
            {
                this.castingSkill = castingSkill;
            }
            if (mana >= 1 && mana <= 1000)
            {
                this.mana = mana;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
