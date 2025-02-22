using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
class PipedStreamExample
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => Writer(pipeServer));
            Thread readerThread = new Thread(() => Reader(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void Writer(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe))
            {
                writer.AutoFlush = true;
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine($"Message {i}");
                    Thread.Sleep(500); // Simulate work
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer error: " + ex.Message);
        }
    }

    static void Reader(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + message);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader error: " + ex.Message);
        }
    }
}