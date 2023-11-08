using Microsoft.AspNetCore.Components;

namespace Pricetool.Tests
{
    public class MockNavigationManager : NavigationManager
    {
        public List<string> NavigatedUris { get; } = new List<string>();

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            NavigatedUris.Add(uri);
        }

        public void Initialize(string baseUri, string uri)
        {
            EnsureInitialized();
            BaseUri = baseUri;
            Uri = uri;
        }

        protected override void EnsureInitialized()
        {
            // Override to do nothing, since we're setting BaseUri and Uri manually in tests
        }
    }

}
