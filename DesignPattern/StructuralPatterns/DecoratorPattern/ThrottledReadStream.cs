using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.DecoratorPattern
{
    /// <summary>
    /// This implementation of the decorator pattern uses the abstract stream class 
    /// from the .NET framework to show the implementation of a decorator.
    /// 
    /// This example uses shows how throttling could be implemented for stream in form of a decorator.
    /// This gives the flexibility of adding the throttling on any type of stream.
    /// e.g. Decoration of a memory stream
    /// var stream1 = new MemoryStream();
    /// var throttledStream1 = new ThrottledReadStream(stream1);
    /// </summary>
    public class ThrottledReadStream : Stream
    {
        /// <summary>
        /// The decorated stream
        /// </summary>
        private Stream _stream;

        /// <summary>
        /// Gets or sets the time span for each throttle interval. e.g. 1000 bytes per 10 seconds
        /// </summary>
        public TimeSpan ThrottledTime { get; set; }
        
        /// <summary>
        /// Gets or sets the amount of bytes which can be transferred per ThrottledTime
        /// </summary>
        public int ThrottledBytes { get; set; }

        /// <summary>
        /// Event which is fired when the maximum allowed throughput is reached
        /// </summary>
        public event EventHandler<EventArgs> ThrottledMaximumReached;

        /// <summary>
        /// Indicates wheather just an event is fired 
        /// </summary>
        public bool ThrottleThroughput { get; set; }

        /// <summary>
        /// In order to allow a combination of decorators, 
        /// every decorator has to take the abstract base class / interface in the constructor
        /// </summary>
        /// <param name="stream">The stream to decorate</param>
        public ThrottledReadStream(Stream stream)
        {
            _stream = stream;
            ThrottleThroughput = true;
            ThrottledTime = new TimeSpan(0, 0, 1);
            ThrottledBytes = int.MaxValue;
        }

        /// <summary>
        /// In order to allow a combination of decorators, 
        /// every decorator has to take the abstract base class / interface in the constructor
        /// </summary>
        /// <param name="stream">The stream to decorate</param>
        /// <param name="throttleThroughput">Indicates if the throughput should be really trottled or just an event is fired when the maximum is reached</param>
        /// <param name="throttledBytes">The maximum throughput in bytes per throttled time interval</param>
        /// <param name="throttledTime">The throttled time interval</param>
        public ThrottledReadStream(Stream stream, bool throttleThroughput, int throttledBytes, TimeSpan throttledTime)
        {
            _stream = stream;
            ThrottleThroughput = throttleThroughput;
            ThrottledBytes = throttledBytes;
            ThrottledTime = throttledTime;
        }

        /// <summary>
        /// Read method is overriden to read from the stream but never more that x bytes (ThrottledBytes) in y time (ThrottledTime)
        /// </summary>
        /// <param name="buffer">The output array</param>
        /// <param name="offset">The offset to start in the output array</param>
        /// <param name="count">Number of bytes to load</param>
        /// <returns>The total number of bytes read into the buffer</returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalNumberOfBytes = 0;
            int currentNumberOfBytes = 0;

            var startTime = DateTime.UtcNow;

            while (totalNumberOfBytes < count)
            {
                int bytesRead = _stream.Read(buffer, currentNumberOfBytes, 1);
                totalNumberOfBytes += bytesRead;
                currentNumberOfBytes += bytesRead;

                var endTime = DateTime.UtcNow;
                var elapsedTime = endTime - startTime;

                bool reset = false;
                // Throttled Time has not elapsed but the transferred byte limit has been exceeded
                if (elapsedTime < ThrottledTime && currentNumberOfBytes > ThrottledBytes)
                {
                    reset = true;
                    // Wait until the next time slot
                    OnThrottledMaximumReached();
                    if (ThrottleThroughput)
                    {
                        Thread.CurrentThread.Join(ThrottledTime - elapsedTime);
                    }

                }
                // ThrottledTime has been elapsed, reset start time and counter
                else if (elapsedTime >= ThrottledTime)
                {
                    reset = true;
                }

                if (reset)
                {
                    currentNumberOfBytes = 0;
                    startTime = DateTime.UtcNow;
                }
            }

            return totalNumberOfBytes;
        }

        /// <summary>
        /// Indicates if the stream can be read
        /// </summary>
        public override bool CanRead
        {
            get { return true; }
        }

        /// <summary>
        /// Indicates if it is possible to seek in the stream
        /// </summary>
        public override bool CanSeek
        {
            get { return false; }
        }

        /// <summary>
        /// Indicates if the stream can be written
        /// </summary>
        public override bool CanWrite
        {
            get { return false; }
        }

        /// <summary>
        /// Stream Length getter
        /// </summary>
        /// <result>Number of bytes in the stream</result>
        public override long Length
        {
            get { return _stream.Length; }
        }

        /// <summary>
        /// Stream position getter
        /// </summary>
        /// <result>Current position in the stream</result>
        public override long Position
        {
            get
            {
                return _stream.Position;
            }
            set
            {
                _stream.Position = value;
            }
        }

        /// <summary>
        ///  Flush method writing buffered data to the stream
        /// </summary>
        public override void Flush()
        {
            _stream.Flush();
        }

        /// <summary>
        /// Set Length method
        /// </summary>
        /// <param name="value">The length value</param>
        public override void SetLength(long value)
        {
            _stream.SetLength(value);
        }

        #region Not implemented methods
        /// <summary>
        /// Write method which is not implemented in this example
        /// </summary>
        /// <param name="buffer">The buffer</param>
        /// <param name="offset">The offset</param>
        /// <param name="count">The byte count</param>
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Seek method which is not implemented in this example
        /// </summary>
        /// <param name="offset">The offset</param>
        /// <param name="origin">The relative position of the offset</param>
        /// <returns>The number of bytes which have been seeked</returns>
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void OnThrottledMaximumReached()
        {
            if (ThrottledMaximumReached != null)
            {
                ThrottledMaximumReached(this, EventArgs.Empty);
            }
        }
    }
}
