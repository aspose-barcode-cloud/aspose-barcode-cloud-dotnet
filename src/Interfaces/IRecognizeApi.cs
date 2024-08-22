using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     RecognizeApi interface
    /// </summary>
    public interface IRecognizeApi
    {

        /// <summary>
        ///     Recognize barcode from file on server using GET requests with parameters in route and query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeBarcodeTypeGetRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeRecognizeBarcodeTypeGetAsync(BarcodeRecognizeBarcodeTypeGetRequest request);

        /// <summary>
        ///     Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeBodyPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeRecognizeBodyPostAsync(BarcodeRecognizeBodyPostRequest request);

        /// <summary>
        ///     Recognize barcode from file in request body using POST requests with parameters in multipart form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeFormPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeRecognizeFormPostAsync(BarcodeRecognizeFormPostRequest request);
    }
}
