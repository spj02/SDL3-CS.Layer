#region License
/* Copyright (c) 2026 Jonas S.
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute
 * it freely, subject to the following restrictions:
 *
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 3. This notice may not be removed or altered from any source distribution.
 */
#endregion

namespace SDL3;

public partial class LYR
{
    /// <summary>
    /// <para>Possible keyboard focus modes.</para>
    /// </summary>
    /// <since>This enum is available since SDL_layer 1.0.0.</since>
    /// <seealso cref="CreateWindow"/>
    /// <seealso cref="Props.WindowCreateKeyboardFocusNumber"/>
    public enum Focus
    {
        /// <summary>
        /// Disable keyboard focus.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Enable focus for top-most layer.
        /// </summary>
        Exclusive = 1,
        
        /// <summary>
        /// Enable regular focus semantics.
        /// </summary>
        OnDemand = 2
    }
}
