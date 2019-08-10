using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTail
{
    class Messages
    {
        #region Neutral/system messages
        /// <summary>
        /// Marker class to continue processing.
        /// </summary>
        public class ContinueProcessing { }
        #endregion

        #region Base message
        public class MessageWithReason
        {
            readonly string _reason;
            public string Reason => _reason;

            public MessageWithReason(string reason)
            {
                _reason = reason;
            }
        }
        #endregion

        #region Success messages
        public class InputSuccess : MessageWithReason
        {
            public InputSuccess(string reason) : base(reason) { }
        }
        #endregion

        #region Error messages
        public class InputError : MessageWithReason
        {
            public InputError(string reason) : base(reason) { }
        }

        public class NullInputError : MessageWithReason
        {
            public NullInputError(string reason) : base(reason) { }
        }

        public class ValidationError : MessageWithReason
        {
            public ValidationError(string reason) : base(reason) { }
        }
        #endregion
    }
}
