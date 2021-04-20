using System.Threading;
using System.Threading.Tasks;

namespace ImageManipulator.Business.Filters.Interfaces
{
    // Each new filter will implement this interface
    public interface IPlugin
    {
        // So I am thinking of having
        // concrete plugins and concrete
        // filters and each plugin will 
        // have its own filter
        /// <summary>
        /// Processes base 64 image and returns the processed image
        /// </summary>
        /// <param name="imageString">Original image.</param>
        /// <param name="filter">Specific effect with parameters.</param>
        /// <returns>Processed image.</returns>
        Task<string> ProcessAsync(
            string imageString,
            IFilter filter,
            CancellationToken cancellationToken);
    }
}
