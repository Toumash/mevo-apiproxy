using System;
using System.Collections.Generic;
using System.Text;

namespace mevo.apiproxy
{
    public class Place
    {
        public int uid { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public bool bike { get; set; }
        public string name { get; set; }
        public object address { get; set; }
        public bool spot { get; set; }
        public int number { get; set; }
        public int bikes { get; set; }
        public int booked_bikes { get; set; }
        public int bike_racks { get; set; }
        public int free_racks { get; set; }
        public int special_racks { get; set; }
        public int free_special_racks { get; set; }
        public bool maintenance { get; set; }
        public string terminal_type { get; set; }
        public List<BikeList> bike_list { get; set; }
        public List<string> bike_numbers { get; set; }
        public object bike_types { get; set; }
        public string place_type { get; set; }
        public bool rack_locks { get; set; }
        public string city { get; set; }
    }

    public class MevoApiRootDto
    {
        public List<Place> places { get; set; }
    }
    public class BatteryPack
    {
        public int percentage { get; set; }
    }

    public class BikeList
    {
        public string number { get; set; }
        public int bike_type { get; set; }
        public List<string> lock_types { get; set; }
        public bool active { get; set; }
        public string state { get; set; }
        public bool electric_lock { get; set; }
        public long boardcomputer { get; set; }
        public int pedelec_battery { get; set; }
        public BatteryPack battery_pack { get; set; }
    }
}
