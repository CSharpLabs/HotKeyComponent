﻿//---------------------------------------------------------------------------- 
//
//  Copyright (C) Jason Graham.  All rights reserved.
// 
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// 
// History
//  06/20/13    Created 
//
//---------------------------------------------------------------------------

namespace System.Windows.Forms
{
    /// <summary>
    /// Contains properties defining the state of an activated hot key.
    /// </summary>
    public class HotKeyState
    {
        #region Properties
        /// <summary>
        /// Gets the hot key.
        /// </summary>
        public HotKey HotKey { get; private set; }

        /// <summary>
        /// Gets the optional user state value.
        /// </summary>
        public object State { get; private set; }

        /// <summary>
        /// Gets the owning <see cref="HotKeyComponent"/> instance.
        /// </summary>
        public HotKeyComponent Owner { get; private set; }

        /// <summary>
        /// Gets if the hot key can be held down to repeatedly invoke events.
        /// </summary>
        public bool AllowRepeat { get; private set; }
        #endregion

        #region Constructors
        private HotKeyState()
        { }

        /// <summary>
        /// Initializes from an owner, hot key, repeat options and optional user state.
        /// </summary>
        /// <param name="owner">The <see cref="HotKeyComponent"/> that created this instance.</param>
        /// <param name="hotkey">The hot key.</param>
        /// <param name="allow_repeat">true to allow repeatedly invoking events; otherwise false.</param>
        /// <param name="state">An optional user state object.</param>
        protected HotKeyState(HotKeyComponent owner, HotKey hotkey, bool allow_repeat, object state = null)
        {
            if (owner == null)
                throw new ArgumentNullException("owner");

            Owner = owner;
            HotKey = hotkey;
            AllowRepeat = allow_repeat;
            State = state;
        }
        #endregion
    }
}
