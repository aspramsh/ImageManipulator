using ImageManipulator.Business.Filters.Interfaces;

namespace ImageManipulator.Business.Filters.Filters
{
    public class ResizeFilter : IFilter
    {
        public string Name { get; set; }

        public int NewSize { get; set; }
    }
}
