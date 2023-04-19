using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Player : IntShowData
    {
        string name;
        List<Items> items = new List<Items>();
        float experience;
        int level;
        float money;

        public void GettingItem(Items item)
        {
            items.Add(item);
        }

        public virtual string GettingName(string name)
        {
            this.name = name;
            return name;
        }

        public virtual float GettingExperience(float experience)
        {
            this.experience = experience;
            return experience;
        }

        public virtual float GettingLevel(int level)
        {
            this.level = level;
            return level;
        }

        public string ShowData()
        {
            return "Nombre: " + name + " " + "Experiencia: " + experience + " " + "Nivel: " + level;
        }

    }

}

