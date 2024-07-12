using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.models
{
    public class LoginSuccessResponse
    {
        public string accessToken { get; set; }
        public string tokenType { get; set; }
    }
}
