using System.Runtime.Serialization;

namespace MauiTABU.GameLogic
{
    [Serializable]
    internal class GameOverExeption : Exception
    {
        public GameOverExeption()
        {
        }

        public GameOverExeption(string? message) : base(message)
        {
        }

        public GameOverExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GameOverExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}