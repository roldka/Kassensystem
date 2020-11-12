using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Kassensystem.Command;
using Kassensystem.ViewModel;

namespace Kassensystem.Model
{
    public class Rechnung
    {
            public Rechnung(int item)
            {
                Item = item;
            }

            public int Item { get; private set; }           
    }
}