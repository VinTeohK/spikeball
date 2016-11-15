﻿/*
 *  Copyright (c) 2016 Rob Harwood <rob@codemlia.com>
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 *  and associated documentation files (the "Software"), to deal in the Software without
 *  restriction, including without limitation the rights to use, copy, modify, merge, publish,
 *  distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 *  Software is furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in all copies or
 *  substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 *  BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 *  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 *  DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
namespace Platformer.Engine
{
    /// <summary>
    /// Enumeration conatining options used to affect the behaviour of trace lines.
    /// </summary>
    public enum TraceLineOptions
    {
        /// <summary>
        /// No options configured.
        /// </summary>
        None = 0,

        /// <summary>
        /// The trace line will ignore entities.
        /// </summary>
        IgnoreEntities = (1 << 0),

        /// <summary>
        /// The trace line will ignore tiles.
        /// </summary>
        IgnoreTiles = (1 << 1),

        /// <summary>
        /// Only trace against entities which have solidity.
        /// </summary>
        SolidOnly = (1 << 2),

        /// <summary>
        /// Ignore tiles/entities with "jump through" solidity.
        /// </summary>
        IgnoreJumpThrough = (1 << 3)
    }
}