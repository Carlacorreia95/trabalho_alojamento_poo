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
        private int id;
        private int capacity { get; set; }
        private float area { get; set; }


        public Accommodation(int id, int capacity, float area) 
        { 
            this.id = id;
            this.capacity = capacity;
            this.area = area;
        }
        public int Id()
        {
            return this.id;
        }

    }
    #region Class_Room 
    public class Room : Accommodation
    {
        private int floor {  get; set; }
        internal Room(int id, int capacity, float area, int floor): base(id, capacity, area)
        {
            this.floor = floor;
        }


    }
    #endregion
    #region Class_villa
    public class Villa : Accommodation
    {
        private bool kitchen;
        private bool sofa_bed;
        private bool living_room;
        internal Villa(int id, int capacity, float area, bool kitchen, bool sofa_bed, bool living_room):base(id, capacity, area)
        {
            this.kitchen = kitchen;
            this.sofa_bed = sofa_bed;
            this.living_room = living_room;
        }
    }
    #endregion
}
