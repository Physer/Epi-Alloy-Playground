using EPiServer.Shell.Navigation;
using System.Collections.Generic;

namespace Alloy.Business
{
    [MenuProvider]
    public class CustomMenuProvider : IMenuProvider
    {
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return new[]
            {
                new UrlMenuItem("Settings", "/global/settings", "/backend")
            };
        }
    }
}