using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Alojamento_POO
{
    public class Accommodation
    {
        private int id { get; set; }
        public int capacity { get; set; }
        public float area { get; set; }

        public int Id { get => id; }
        public Accommodation(int id, int capacity, float area) 
        { 
            this.id = id;
            this.capacity = capacity;
            this.area = area;
        }

    }
    #region Class_Room 
    public class Room : Accommodation
    {
        public int floor {  get; set; }
        public Room(int id, int capacity, float area, int floor): base(id, capacity, area)
        {
            this.floor = floor;
        }


    }
    #endregion
    #region Class_villa
    public class Villa : Accommodation
    {
        public bool kitchen { get; set; }
        public bool sofa_bed { get; set; }
        public bool living_room { get; set; }
        public Villa(int id, int capacity, float area, bool kitchen, bool sofa_bed, bool living_room):base(id, capacity, area)
        {
            this.kitchen = kitchen;
            this.sofa_bed = sofa_bed;
            this.living_room = living_room;
        }
    }
    #endregion
}
