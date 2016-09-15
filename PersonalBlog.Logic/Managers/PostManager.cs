using System;
using System.IO;
using PersonalBlog.Logic.Managers.Results;

namespace PersonalBlog.Logic.Managers
{
    public static class PostManager
    {
        public static PostPreviewCalculationResult ProcessSource(string source)
        {
            int previewEndIndex = source.IndexOf(ConstsManager.PreviewEndString, StringComparison.Ordinal);
            if (previewEndIndex == -1)
                throw new InvalidDataException("Post source should contains preview end string macros!");

            return new PostPreviewCalculationResult
            {
                PreviewEndIndex = previewEndIndex,
                CleanedSource = source.Replace(ConstsManager.PreviewEndString, string.Empty)
            };
        }

        public static string RestoreSource(string source, int previewEndIndex)
        {
            if (previewEndIndex < 0 || previewEndIndex > source.Length)
                throw new ArgumentOutOfRangeException("previewEndIndex", "previewEndIndex can't be less then source length.");

            return source.Insert(previewEndIndex, ConstsManager.PreviewEndString);
        }
    }
}
