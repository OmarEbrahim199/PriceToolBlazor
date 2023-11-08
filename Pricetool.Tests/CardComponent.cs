using Bunit;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Pricetool.Components.Information;
using Prisværktøj.Infrastructure.Models;

namespace Pricetool.Tests
{
    public class CardComponent
    {
        [Fact]

        public void CardComponent_NavigatesToCorrectLink_OnClick()
        {
            // Arrange
            var ctx = new TestContext();
            var mockNavManager = new MockNavigationManager();
            ctx.Services.AddSingleton<NavigationManager>(mockNavManager);
            var expectedLink = "https://localhost:7294/details/1";

            // Act
            var cut = ctx.RenderComponent<InfoCard>(parameters => parameters
                .Add(p => p.CardData, new CardInfo { Link = expectedLink })
            );

            var anchorElement = cut.Find("a");

            // Assert
            Assert.Equal(expectedLink, anchorElement.GetAttribute("href"));
        }


    }
}



