using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinParkingSystem.Models
{
    public class ParkingSlot
    {
        public int SlotNumber { get; set; }
        public bool IsOccupied { get; set; }
        public DateTime? EntryTime { get; set; }
    }
}
