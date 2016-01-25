using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Winform.UI.Controls.PluggableTabControl
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AddInRendererAttribute : Attribute
    {
        #region Destructor

        ~AddInRendererAttribute()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        // Attribute constructor for positional parameters.
        public AddInRendererAttribute(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        // Accessors.
        public string Name { get; private set; }
        public string Description { get; private set; }

        // Property for named parameters.
        public bool IsSupportEditor { get; set; }
        public string DeveloperName { get; set; }
        public string VersionNumber { get; set; }
    }
}
