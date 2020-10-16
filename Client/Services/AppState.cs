using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TheDiveLog.Client.Services
{
    public class AppState
    {
        public static string User { get; set; }

        public string Email { get; private set; } = string.Empty;

        public void UpdateEmail(ComponentBase Source, string Email)
        {
            this.Email = Email;
            NotifyStateChanged(Source, "Email");
        }

        public event Action<ComponentBase, string> StateChanged;
        private void NotifyStateChanged(ComponentBase Source, string Property) => StateChanged?.Invoke(Source, Property);
    }
}
