using System;

namespace OOP3
{
    class FileLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
