using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrNotification(this IJSRuntime jsRuntime, string type)
        {
            var message = "";
            if (type == "success")
            {
                message = "Good Job Dude";
            }
            else if (type == "warning")
            {
                message = "Careful, maybe an error here";
            }
            else
            {
                message = "It's very wrong";
            }

            jsRuntime.InvokeVoidAsync("showToastr", type, message);
        }

        public static async Task SweetAlertNotification(this IJSRuntime jsRuntime, string type)
        {
            var message = "";
            if (type == "success")
            {
                message = "Good Job Dude";
            }
            else
            {
                message = "It's very wrong";
            }

            jsRuntime.InvokeVoidAsync("showSweetAlert", type, message);
        }
    }
}
