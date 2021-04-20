using ImageManipulator.Business.Filters.Filters;
using ImageManipulator.Business.Filters.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ImageManipulator.Business.Plugins
{
    public class ResizePlugin : IPlugin
    {
        public async Task<string> ProcessAsync(
            string imageString,
            IFilter filter,
            CancellationToken cancellationToken)
        {
            if (!(filter is ResizeFilter resizeFilter))
            {
                throw new Exception("Invalid filter.");
            }

            // TODO: do some magic to resize
            var modified = imageString;
            await Task.Delay(1000, cancellationToken);

            return modified;
        }
    }
}
