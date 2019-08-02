namespace Agilite
{
    public static class AgilEnums
    {
        public enum OutFormatAj
        {
            None,
            Array,
            Json
        }

        public enum OutFormatSj
        {
            None,
            String,
            Json
        }

        public enum RespondType
        {
            None,
            ArrayBuffer,
            Blob,
            Document,
            Json,
            Text,
            Stream
        }

        public enum SortOrder
        {
            None,
            Ascending,
            Descending,
            AscendingValue,
            DescendingValue
        }
    }
}