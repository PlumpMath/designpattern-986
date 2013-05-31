using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.DecoratorPattern
{
    public class ThrottledReadStream : Stream
    {
        private Stream _stream;

        public TimeSpan ThrottledTime { get; set; }
        public int ThrottledBytes { get; set; }
        public event EventHandler<bool> ThrottledMaximumReached;
        public bool ThrottleThroughput { get; set; }

        public ThrottledReadStream(Stream stream)
        {
            _stream = stream;
            ThrottleThroughput = true;
            ThrottledTime = new TimeSpan(0, 0, 1);
            ThrottledBytes = int.MaxValue;
        }

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

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanSeek
        {
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        #region Not implemented methods
        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override long Length
        {
            get { throw new NotImplementedException(); }
        }

        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void OnThrottledMaximumReached()
        {
            if (ThrottledMaximumReached != null)
            {
                ThrottledMaximumReached(this, true);
            }
        }
    }
}
