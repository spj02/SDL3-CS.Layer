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
    /// <para>Possible layers to place a window on.</para>
    /// </summary>
    /// <since>This enum is available since SDL_layer 1.0.0.</since>
    /// <seealso cref="CreateWindow"/>
    /// <seealso cref="Props.WindowCreateLayerNumber"/>
    public enum Layer
    {
        /// <summary>
        /// The layer is unspecified.
        /// </summary>
        Invalid = 0,
        
        /// <summary>
        /// Place the window on the background layer.
        /// </summary>
        Background = 1,
        
        /// <summary>
        /// Place the window on the bottom layer.
        /// </summary>
        Bottom = 2,
        
        /// <summary>
        /// Place the window on the top layer.
        /// </summary>
        Top = 3,
        
        /// <summary>
        /// Place the window on the overlay layer.
        /// </summary>
        Overlay = 4
    }
}
