using Microsoft.AspNetCore.Components;
using Radzen;

namespace Pricetool.Models
{
    public class DialogServices
    {
        private DialogService RadzenDialogService;

        public DialogServices(DialogService dialogService)
        {
            RadzenDialogService = dialogService;
        }


        public async Task OpenSideAsyncDialog<T>(string title) where T : ComponentBase
        {

            //  Task.FromResult to return a completed Task
            await Task.FromResult(RadzenDialogService.OpenSideAsync<T>(title, options:
                     new SideDialogOptions
                     {
                         CloseDialogOnOverlayClick = false,
                         ShowClose = false,
                         Position = DialogPosition.Top,
                         ShowMask = false,
                         ShowTitle = false,
                         Height = "100%",
                         Width = "100%",

                     })); ;


        }

        public async Task CloseDialog()
        {
            await Task.Run(() =>
            {
                // CPU-bound work here
                RadzenDialogService.CloseSide();
            });


        }



        public async Task OpenSideAsyncInfoDialog<T>(string title) where T : ComponentBase
        {

            //  Task.FromResult to return a completed Task
            await Task.FromResult(RadzenDialogService.OpenSideAsync<T>(title, options:
                     new SideDialogOptions
                     {

                         CloseDialogOnOverlayClick = true,
                         ShowClose = false,
                         Position = DialogPosition.Top,
                         ShowMask = false,


                         Height = "60%",
                         Width = "100%",
                         Style = "top: 6%;",

                     })); ;
        }





    }

}
