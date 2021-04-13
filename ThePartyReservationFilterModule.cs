using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class ThePartyReservationFilterModule
    {
        delegate List<string> FilterGuestsDelegate(List<string> guests, string param);
        static void Main()
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            string nextLine = Console.ReadLine();
            string command = nextLine.Substring(0, nextLine.IndexOf(';'));
            List<string> filters = new List<string>();
            FilterGuestsDelegate del = null;

            while (command != "Print")
            {
                string filterParam = nextLine.Substring(nextLine.IndexOf(';') + 1);

                if (command == "Add filter")
                {
                    filters.Add(filterParam);
                }
                else
                {
                    filters.Remove(filterParam);
                }

                nextLine = Console.ReadLine();
                if (nextLine.IndexOf(';') > 0)
                {
                    command = nextLine.Substring(0, nextLine.IndexOf(';'));
                }
                else
                {
                    command = nextLine;
                }
            }

            foreach (string item in filters)
            {
                string filter = item.Substring(0, item.IndexOf(';'));
                string param = item.Substring(item.IndexOf(';') + 1);
                switch (filter)
                {
                    case "Starts with": del += FilterStartsWith; break;
                    case "Ends with": del += FilterEndsWith; break;
                    case "Length": del += FilterWithLength; break;
                    case "Contains": del += FilterContains; break;
                    default:
                        break;
                }
                guests = del(guests, param);
            }
            Console.WriteLine(string.Join(" ", guests));
        }
        static List<string> FilterStartsWith(List<string> guests, string param)
        {
            return guests.Where(x => !x.StartsWith(param)).ToList();
        }
        static List<string> FilterEndsWith(List<string> guests, string param)
        {
            return guests.Where(x => !x.EndsWith(param)).ToList();
        }
        static List<string> FilterWithLength(List<string> guests, string param)
        {
            return guests.Where(x => x.Length != int.Parse(param)).ToList();
        }
        static List<string> FilterContains(List<string> guests, string param)
        {
            return guests.Where(x => !x.Contains(param)).ToList();
        }
    }
}
