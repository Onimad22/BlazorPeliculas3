using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        public static async ValueTask<bool>Confirm(this IJSRuntime js,string mensaje)
        {
            await js.InvokeVoidAsync("console.log","prueba de consoleLog");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
