using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.utils
{
    public class ComboBoxItem
    {
        public string DisplayName { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return DisplayName; // This is important for display in ComboBox
        }
    }
}
