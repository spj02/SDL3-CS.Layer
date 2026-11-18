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

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

public partial class LYR
{
    [ExcludeFromCodeCoverage]
    [LibraryImport(LYRLibrary, EntryPoint = "LYR_Init"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.I1)]
    private static partial bool LYR_Init();
    private delegate bool InitNative();
    private static InitNative InitNativeFunction = LYR_Init;

    /// <code>extern SDL_DECLSPEC bool SDLCALL LYR_Init(void);</code>
    /// <summary>
    /// <para>Initialize SDL_layer.</para>
    /// <para>This function requires SDL's video subsystem to be initialized using the
    /// Wayland backend, calling it when already initialized is a no-op.</para>
    /// </summary>
    /// <returns><c>true</c> on success or <c>false</c> on failure; call <see cref="GetError"/> for more
    /// information.</returns>
    /// <since>This function is available since SDL_layer 1.0.0.</since>
    /// <seealso cref="Quit"/>
    public static bool Init()
    {
        return InitNativeFunction();
    }

    [ExcludeFromCodeCoverage]
    [LibraryImport(LYRLibrary, EntryPoint = "LYR_Quit"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial void LYR_Quit();
    private delegate void QuitNative();
    private static QuitNative QuitNativeFunction = LYR_Quit;

    /// <code>extern SDL_DECLSPEC void SDLCALL LYR_Quit(void);</code>
    /// <summary>
    /// <para>Deinitialize SDL_layer.</para>
    /// <para>Calling this function when already deinitialized is a no-op.</para>
    /// </summary>
    /// <since>This function is available since SDL_layer 1.0.0.</since>
    public static void Quit()
    {
        QuitNativeFunction();
    }

    [ExcludeFromCodeCoverage]
    [LibraryImport(LYRLibrary, EntryPoint = "LYR_CreateWindow"), UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    private static partial IntPtr LYR_CreateWindow(uint props);
    private delegate IntPtr CreateWindowNativeDelegate(uint props);
    private static CreateWindowNativeDelegate CreateWindowNativeFunction = LYR_CreateWindow;

    /// <code>extern SDL_DECLSPEC SDL_Window *SDLCALL LYR_CreateWindow(SDL_PropertiesID props);</code>
    /// <summary>
    /// <para>Create a window with the specified properties.</para>
    /// <para>The window size and position are requests and may be adjusted by the
    /// compositor. Margins are only meaningful for anchored edges. The exclusive
    /// zone is also subject to compositor policy.</para>
    /// <para>These are the supported properties:</para>
    /// <list type="bullet">
    /// <item><see cref="Props.WindowCreateLayerNumber"/>: The layer on which to place the
    /// window, one of the values of <see cref="Layer"/>.</item>
    /// <item><see cref="Props.WindowCreateAnchorNumber"/>: A bitmask of <see cref="Anchor"/> values
    /// specifying which edges of the display the window should be anchored to.
    /// If no edges are specified, the window is centered.</item>
    /// <item><see cref="Props.WindowCreateDisplayNumber"/>: The SDL display ID on which to
    /// create the window. If not specified, the compositor chooses the display.</item>
    /// <item><see cref="Props.WindowCreateNamespaceString"/>: A namespace identifying the
    /// surface to the compositor. This can be used by the compositor to
    /// identify and configure surfaces belonging to a particular application.</item>
    /// <item><see cref="Props.WindowCreateMarginTopNumber"/>: The margin from the top edge
    /// of the display, in screen coordinates.</item>
    /// <item><see cref="Props.WindowCreateMarginBottomNumber"/>: The margin from the bottom
    /// edge of the display, in screen coordinates.</item>
    /// <item><see cref="Props.WindowCreateMarginLeftNumber"/>: The margin from the left
    /// edge of the display, in screen coordinates.</item>
    /// <item><see cref="Props.WindowCreateMarginRightNumber"/>: The margin from the right
    /// edge of the display, in screen coordinates.</item>
    /// <item><see cref="Props.WindowCreateKeyboardFocusNumber"/>: The keyboard focus mode
    /// for the window, one of the values of <see cref="Focus"/>.</item>
    /// <item><see cref="Props.WindowCreateExclusiveZoneNumber"/>: The exclusive zone of
    /// the window, in screen coordinates. A positive value reserves space
    /// along the anchored edge so that other windows do not overlap it.
    /// A value of <c>0</c> indicates that no space should be reserved, and <c>-1</c>
    /// requests an exclusive zone extending to the edge of the display.</item>
    /// <item><see cref="Props.WindowCreateExclusiveEdgeNumber"/>: The edge of the display
    /// against which the exclusive zone should be applied. One of the
    /// <see cref="Anchor"/> values. If not specified, the compositor determines the
    /// edge from the window's anchors.</item>
    /// <item><see cref="Props.WindowCreateIgnorePointerBoolean"/>: If <c>true</c>, the window
    /// does not receive pointer input.</item>
    /// </list>
    /// </summary>
    /// <seealso cref="SDL.DestroyWindow"/>
    /// <seealso cref="SDL.CreateProperties"/>
    /// <seealso cref="SDL.GetWindowProperties"/>
    /// <seealso cref="SDL.CreateWindowWithProperties"/>
    public static IntPtr CreateWindow(uint props)
    {
        return CreateWindowNativeFunction(props);
    }
}
